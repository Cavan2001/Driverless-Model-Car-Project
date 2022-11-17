using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace videocapture
{
    public class CarController
    {
        protected bool _connected = false;
        protected System.IO.Ports.SerialPort port;

        /// <summary>
        /// Create a new car controller object. 
        /// </summary>
        public CarController()
        {
            port = new System.IO.Ports.SerialPort();
            port.BaudRate = 115200;
        }

        /// <summary>
        /// Sets the COM port the micro:bit is connected to. Use System.IO.Ports.SerialPort.GetPortNames to get a list of available ports
        /// </summary>
        /// <param name="portName"></param>
        public void SetPort(string portName)
        {
            if (portName == "")
            {
                MessageBox.Show("Select a communications port.");
            }
            else {
                Connected = false;
                port.PortName = portName;

            }
            
        }

        /// <summary>
        /// Connect or disconnects to/from the car
        /// </summary>
        public bool Connected
        {
            get
            {
                return port.IsOpen;
            }
            set
            {
                if (value)
                {
                    port.Parity = System.IO.Ports.Parity.None;
                    port.DataBits = 8;
                    port.StopBits = System.IO.Ports.StopBits.One;   
                    port.Open();
                    port.WriteLine("\n\r\x04\r");
                    System.Threading.Thread.Sleep(1000);
                    port.WriteLine("from microbit import *\r");
                    port.WriteLine("import radio\r");
                    port.WriteLine("radio.on()\r");
                    port.DataReceived += Port_DataReceived;
                } else
                {
                    port.Close();
                }
            }
        }

        public event ReceivedDataHandler ReceivedData;

        public class ReceiveLineEventArgs : EventArgs
        {
            public string DataReceived;
        }

        public delegate void ReceivedDataHandler(object sender, ReceiveLineEventArgs e);
        protected string lineReceived = "";
        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            lineReceived += port.ReadExisting();
            if(lineReceived.Contains("\r"))
            {
                string []parts = lineReceived.Split('\r');
                if (ReceivedData != null)
                {
                    for(int i = 0; i < parts.Length - 1; i++)
                    {
                        ReceiveLineEventArgs args = new ReceiveLineEventArgs();
                        args.DataReceived = parts[i];
                        Match m = Regex.Match(args.DataReceived, "'(-?\\d+)'");
                        //if(m.Success)
                        //{
                        //    currentDistance= int.Parse(m.Groups[1].Value);
                        //}
                        //ReceivedData(this, args);

                    }
                    lineReceived = parts[parts.Length-1];   
                }


            }
            
            
        }

        /// <summary>
        /// Switches the front lights on or off
        /// </summary>
        /// <param name="lights"></param>
        public void SetHeadLights(bool lights)
        {
            send("H" + (lights ? "1" : "0"));
        }

        /// <summary>
        /// Send radio control via the micro:bit
        /// </summary>
        /// <param name="radiostring"></param>
        protected void send(string radiostring)
        {
            port.WriteLine("radio.send(\"" + radiostring + "\")\n\r");
        }

        /// <summary>
        /// Switches the rear lights on or off
        /// </summary>
        /// <param name="lights"></param>
        public void SetBrakeLights(bool lights)
        {
            send("B" + (lights?"1":"0"));
        }

        //ultrasound sensor currently out of use
        //protected int currentDistance;

        //public int GetDistance()
        //{
        //    if(Connected)
        //    {
        //        send("Gd");
        //        port.BaseStream.Flush();
        //        port.WriteLine("radio.receive()\n\r");
        //        port.WriteLine("radio.receive()\n\r");
        //        port.BaseStream.Flush();
        //        return currentDistance;
        //    }
        //    return 0;
            
        //}

        /// <summary>
        /// Switches the horn on or off
        /// </summary>
        /// <param name="horn"></param>
        public void SetHorn(int frequency)
        {
            send("*" + frequency);
        }

        /// <summary>
        /// Send custom command. Should not be used in production - just for test purposes.
        /// </summary>
        /// <param name="command">Command to send</param>
        public void Send(string command)
        {
            send(command);
        }

        /// <summary>
        /// Switches the door open motor on or off
        /// </summary>
        /// <param name="doors"></param>
        public void OpenDoors(bool doors)
        {
            send("D" + (doors?"1":"0"));
        }

        /// <summary>
        /// Sets the speed (from -1023 to +1023). 0 will stop the car
        /// </summary>
        /// <param name="speed">Speed of the car (-1023 to 1023)</param>
        public void SetSpeed(int speed)
        {
            send("V" + speed);
        }

        /// <summary>
        /// Sets speed to 0 and direction to Forwards
        /// </summary>
        public void Stop()
        {
            SetSpeed(0);
            Steer(Direction.Forwards);
        }

        /// <summary>
        /// Directions the car can steer
        /// </summary>
        public enum Direction
        {
            Forwards, Left, Right
        }

        /// <summary>
        /// Sets the car direction (assuming it's going forwards)
        /// </summary>
        /// <param name="direction">Direction.Forwards, Direction.Left or Direction.Right</param>
        public void Steer(Direction direction)
        {
            string d = "F";
            switch(direction)
            {
                case Direction.Forwards:
                    d = "F";
                    break;
                case Direction.Left:
                    d = "L";
                    break;
                case Direction.Right:
                    d = "R";
                    break;
            }
            send("S" + d);
        }
    }
}
