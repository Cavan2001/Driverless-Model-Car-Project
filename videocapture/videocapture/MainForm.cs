using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using System.Management;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
 
namespace videocapture
{
    //the main class for the image processing, includes the videocapture, the FPS counter and the find contours code.
    public partial class MainForm : Form
    {
        //creates a new object of the car controller API
        protected CarController car = new CarController();

        //declares a new videocapture called capture and declares some of the global variables
        VideoCapture capture;
        bool Pause = false;
        int framecount = 0;
        bool cap = false;
        int speed;
        public MainForm()        
        {
            InitializeComponent();


            //when the form loads the default values for the mask are declared
            tbhup.Value = 255;
            tbsup.Value = 255;
            tbvup.Value = 255;

            tbhlow.Value = 0;
            tbslow.Value = 0;
            tbvlow.Value = 0;
            
           
        }


        /// <summary>
        /// when the play button is pressed all of the image proccessing is done in this function, the video feed is displayed in the form and the object is located
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      public async void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //runs the camera connect function to see if the camera is connected 
            bool camera_check = Camera_Connect();
            //clears the picturebox for the preview
            PBPreview.Image = null;

            if (camera_check == true)
                {
            Pause = false;
            try
            {

                //the fps timer starts when the play buuton is pressed
                TimerFPS.Start();
                capture = new VideoCapture(0);

               
                


                while (!Pause)
                {

                    Mat m = new Mat();
                    //the image stored in the matrix "m" (which is the current frame of the video) is now stored as a single image that is input inot the picturebox
                    capture.Read(m);

                    //value of the framecount increments by 1 everyt time a new images s inputted into the picturebox
                    framecount += 1;

                    if (!m.IsEmpty)
                    {

                        //declares two images onw HSV for the mask and one BGR for the user to view in the proper colour space
                        Image<Hsv, Byte> imgHSV = m.ToImage<Hsv, Byte>();
                        Image<Bgr, byte> imgbgr = m.ToImage<Bgr, byte>();

                        //splits the HSV image up into three, single channeled, grey scaled images.
                        //sets the threshold values to equal the values on the sliders in the UI
                        Image<Gray, Byte>[] channels = imgHSV.Split();
                        Hsv upperHSV = new Hsv(tbhup.Value, tbsup.Value, tbvup.Value);
                        Hsv lowerHSV = new Hsv(tbhlow.Value, tbslow.Value, tbvlow.Value);

                        //outputs the values of the upper and lower bound values to the labels next to the sliders
                        Lbllowh.Text = tbhlow.Value.ToString();
                        Lbllows.Text = tbslow.Value.ToString();
                        Lbllowv.Text = tbvlow.Value.ToString();
                        Lbluph.Text = tbhup.Value.ToString();
                        Lblups.Text = tbsup.Value.ToString();
                        Lblupv.Text = tbvup.Value.ToString();


                        //setting the image to include the mask threshold set using the sliders.
                        Image<Gray, Byte> threshold = imgHSV.InRange(lowerHSV, upperHSV);


                        //finding the contours of the image
                        Image<Gray, byte> imgoutput = imgHSV.InRange(lowerHSV, upperHSV);
                        Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                        Mat hier = new Mat();

                        //Tell the function what image to detect from, outputs the information in the array contours. tell it what contoursto detect (external), and what method to use (simple)
                        CvInvoke.FindContours(imgoutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                        //draws the contours created in the last function onto the spceified image.


                        //creating a new dictionary top store the data of the area of the contours found
                        Dictionary<int, double> dict = new Dictionary<int, double>();

                        //check's to see if any contours have been found in the image
                        if (contours.Size > 0)
                        {
                            //adds the area data of every contour into the dictionary
                            for (int i = 0; i < contours.Size; i++)
                            {
                                double area = CvInvoke.ContourArea(contours[i]);
                                dict.Add(i, area);
                            }
                        }

                        //orders the dictionary by descending order and the ".take(1)! means it is only taking the top result 
                        //so the contour with the largest area
                        var item = dict.OrderByDescending(v => v.Value).Take(1);

                        
                        foreach (var it in item)
                        {
                            int key = int.Parse(it.Key.ToString());
                            //draws a rectangle around the largest contour found
                            Rectangle rect = CvInvoke.BoundingRectangle(contours[key]);
                            CvInvoke.Rectangle(imgbgr, rect, new MCvScalar(0, 255, 0), 3);
                            // the centre coordinate of the tracked rectangle
                            Point centre = new Point();
                            centre.X = rect.X + (rect.Width / 2);
                            centre.Y = rect.Y + (rect.Height / 2);

                            lblrectx.Text = "rectangle x:" + centre.X.ToString();
                            lblrecty.Text = "rectangle y:" + centre.Y.ToString();

                            Location(centre.X, centre.Y);



                        }




                        //drwaing the images to the pictureboxes
                        PBPreview.Image = imgbgr.Bitmap;
                        pbFiltered.Image = threshold.ToBitmap();

                        //retrieving the fps property from the capture properties feature, and then setting the delay to the FPS value
                        double fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(Convert.ToInt32(fps));

                    }
                    else
                    {
                        
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
         else
         {
               
          MessageBox.Show("Connect the camera");              
         }
      }

        /// <summary>
        /// the timer that ticks every second pasting the count of the frames to a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerFPS_Tick(object sender, EventArgs e)
        {
            double fps = framecount;
            lblFPS.Text = fps.ToString() + " FPS";
            framecount = 0;
            
        }

        /// <summary>
        /// sets the current communictaion port for the car to the selected port in the
        /// listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            car.SetPort(lbCommPorts.Text);
            car.Connected = true;
        }
        /// <summary>
        /// a function that takes the centre coordinate of the rectangle and checks what region of the image they are and returns a value
        /// </summary>
        /// <param name="x">the centre x coordinate of the rect</param>
        /// <param name="y">the centre y coordinate of the rect</param>
        /// <returns>at the moment returns a string that changes a label, but will change to be a value based on an array of regions</returns>
        private new string Location(int x, int y)
        {
            //Top left
            if ((x < 213) & (y < 160))
            {
                lblrectx.ForeColor = System.Drawing.Color.Red;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(700);
                        car.Steer(CarController.Direction.Left);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Top Left";
            }
            //Middle Left
            else if (((x < 213) & ((y > 160) & (y < 320))))
            {
                lblrectx.ForeColor = System.Drawing.Color.White;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(500);
                        car.Steer(CarController.Direction.Left);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Middle Left";
            }
            //bottom Left
            else if ((x < 213) & ((y > 320) & (y < 480)))
            {
                lblrectx.ForeColor = System.Drawing.Color.Cyan;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(0);
                        car.Steer(CarController.Direction.Left);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Bottom Left";
            }
            //Top Centre
            else if (((213 < x) & (x < 427)) & (y < 160))
            {
                lblrectx.ForeColor = System.Drawing.Color.Orange;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(700);
                        car.Steer(CarController.Direction.Forwards);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Top Centre";
            }
            //Middle Centre
            else if (((213 < x) & (x < 427)) & ((y > 160) & (y < 320)))
            {
                lblrectx.ForeColor = System.Drawing.Color.Aqua;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(500);
                        car.Steer(CarController.Direction.Forwards);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Middle Centre";
                
                

            }
            //Bottom Centre
            else if (((213 < x) & (x < 427)) & (y < 480))
            {
                lblrectx.ForeColor = System.Drawing.Color.Yellow;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(0);
                        car.Steer(CarController.Direction.Forwards);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Bottom Centre";
            
            }

            //Top Right
            else if (((427 < x) & (x < 640)) & (y < 160))
            {
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(700);
                        car.Steer(CarController.Direction.Right);
                    }
                }
                
                lblrectx.ForeColor = System.Drawing.Color.Green;
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Top Right";

            }
            //Middle Right
            else if (((427 < x) & (x < 640)) & ((y > 160) & (y < 320)))
            {

                lblrectx.ForeColor = System.Drawing.Color.PeachPuff;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(500);
                        car.Steer(CarController.Direction.Right);
                    }
                }
                //changing the label to indicate object location
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Middle Right";

            }
            //Bottom Right
            else if (((427 < x) & (x < 640)) & (y < 480))
            {
                //driving the car towards the object
                lblrectx.ForeColor = System.Drawing.Color.Purple;
                if (car.Connected == true)
                {
                    if (Btncom.Checked == true)
                    {
                        car.SetSpeed(0);
                        car.Steer(CarController.Direction.Right);
                    }
                }
                return lblrectx.Text = "rectangle x:" + x.ToString() + "  Bottom Right";

            }
            else
            {
                //changing the label to indicate object location
                lblrectx.ForeColor = System.Drawing.Color.Black;
                return lblrectx.Text = "rectangle x:" + x.ToString();
            }

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //upon loading the form the manual button is automatically checked
            Btnmanual.Checked = true;
            
        }

        

        private  bool Camera_Connect()
            {
            bool connected = false; 
            var UsbDevices = USBDeviceInfo.GetUSBDevices();
            string report = "";
            int i = 0;
            
            foreach (var usbDevice in UsbDevices)
            {
               if (usbDevice.DeviceID.ToLower().Contains(@"usb\vid_18ec&pid_5850"))
               {
                    report += "DeviceID:" + usbDevice.DeviceID + "\n";
                  connected = true;
               }

            }

           // MessageBox.Show(report);
            return connected;

            }
        /// <summary>
        /// A button that scans all the available communications ports on the device and allows the user to select the 
        /// appropriate port for the microbit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scanPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbCommPorts.Items.Clear();
            lbCommPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        //event handler for a KeyDown 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            bool lightState = false;
            if (car.Connected == true)
            {
                switch (e.KeyCode)
                {
                    //when the left arrow key is pressed the car steers left 
                    case Keys.Left:
                        car.Steer(CarController.Direction.Left);
                        break;

                    case Keys.Right:
                        //when the right arrow key is pressed the car steers right
                        car.Steer(CarController.Direction.Right);
                        break;

                    case Keys.Up:
                        //when the Up arrow key is pressed the speed is sed to full forward
                        speed = 1000;
                        car.SetSpeed(speed);
                        break;

                    case Keys.Down:
                        //when the Down arrow key is pressed the speed is set to full backward
                        speed = -800;
                        car.SetSpeed(speed);
                        break;

                    case Keys.Space:
                        //when the spacebar is pressed the speed is set to 0 (stop)
                        car.SetSpeed(0);
                        break;
                    case Keys.X:
                        //when the spacebar is pressed the speed is set to 0 (stop)
                        //car.Steer(CarController.Direction.Foxxxx
                        car.Steer(CarController.Direction.Forwards);
                        break;
                    case Keys.D:
                        car.OpenDoors(true);
                        break;
                    case Keys.L:
                        
                        //if (lightState == false)
                       // {
                            car.SetHeadLights(true);
                            car.SetBrakeLights(true);
                            lightState = true;
                       // }
                       // else
                        //{
                           //car.SetHeadLights(false);
                           // car.SetBrakeLights(false);
                           // lightState = false;

                       // }

                        break;
                    case Keys.O:
                        car.SetHeadLights(false);
                        car.SetBrakeLights(false);
                        lightState = false;
                        break;

                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            //when the key is lifted after a press the car stops accelerateing, and steers forward
            switch (e.KeyCode)
            {
                case Keys.Up:
                    speed = 0;
                    car.SetSpeed(speed);
                    break;
                case Keys.Down:
                    speed = 0;
                    car.SetSpeed(speed);
                    break;
                case Keys.Left:
                    car.Steer(CarController.Direction.Forwards);
                    break;
                case Keys.Right:
                    car.Steer(CarController.Direction.Forwards);
                    break;
            }
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions controls = new Instructions();
            controls.Visible = true;
        }
    }
}
/// <summary>
/// Generates a list of all the USB devices connected to the PC, and information about it
/// </summary>
public class USBDeviceInfo
{
    public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
    {
        //retrieves the deviceID, pnpDeviceID and a description of the USBDevice
        this.DeviceID = deviceID;
        this.PnpDeviceID = pnpDeviceID;
        this.Description = description;
    }
    public string DeviceID { get; private set; }
    public string PnpDeviceID { get; private set; }
    public string Description { get; private set; }


    //generating the list
    public static List<USBDeviceInfo> GetUSBDevices()
    {
        List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

        ManagementObjectCollection collection;
        using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
            collection = searcher.Get();

        foreach (var device in collection)
        {
            //gets different properties of the USB device 
            devices.Add(new USBDeviceInfo(
            (string)device.GetPropertyValue("DeviceID"),
            (string)device.GetPropertyValue("PNPDeviceID"),
            (string)device.GetPropertyValue("Description")
            ));
        }

        collection.Dispose();
        return devices;
    }
}

