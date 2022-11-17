namespace videocapture
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.scanPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PBPreview = new System.Windows.Forms.PictureBox();
            this.lblFPS = new System.Windows.Forms.Label();
            this.TimerFPS = new System.Windows.Forms.Timer(this.components);
            this.pbFiltered = new System.Windows.Forms.PictureBox();
            this.tbhlow = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbllowv = new System.Windows.Forms.Label();
            this.Lbllows = new System.Windows.Forms.Label();
            this.Lbllowh = new System.Windows.Forms.Label();
            this.tbvlow = new System.Windows.Forms.TrackBar();
            this.tbslow = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lblupv = new System.Windows.Forms.Label();
            this.Lblups = new System.Windows.Forms.Label();
            this.Lbluph = new System.Windows.Forms.Label();
            this.tbvup = new System.Windows.Forms.TrackBar();
            this.tbsup = new System.Windows.Forms.TrackBar();
            this.tbhup = new System.Windows.Forms.TrackBar();
            this.lblrectx = new System.Windows.Forms.Label();
            this.lblrecty = new System.Windows.Forms.Label();
            this.lbCommPorts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btncom = new System.Windows.Forms.RadioButton();
            this.Btnmanual = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhlow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbvlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbslow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbvup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhup)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(43)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.btnConnect,
            this.scanPortsToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 22);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // scanPortsToolStripMenuItem
            // 
            this.scanPortsToolStripMenuItem.Name = "scanPortsToolStripMenuItem";
            this.scanPortsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.scanPortsToolStripMenuItem.Text = "Scan Ports";
            this.scanPortsToolStripMenuItem.Click += new System.EventHandler(this.scanPortsToolStripMenuItem_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // PBPreview
            // 
            this.PBPreview.BackColor = System.Drawing.Color.Transparent;
            this.PBPreview.Image = ((System.Drawing.Image)(resources.GetObject("PBPreview.Image")));
            this.PBPreview.Location = new System.Drawing.Point(228, 45);
            this.PBPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBPreview.Name = "PBPreview";
            this.PBPreview.Size = new System.Drawing.Size(640, 480);
            this.PBPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPreview.TabIndex = 4;
            this.PBPreview.TabStop = false;
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.BackColor = System.Drawing.Color.Transparent;
            this.lblFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPS.ForeColor = System.Drawing.Color.White;
            this.lblFPS.Location = new System.Drawing.Point(626, 24);
            this.lblFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(40, 18);
            this.lblFPS.TabIndex = 5;
            this.lblFPS.Text = "FPS";
            // 
            // TimerFPS
            // 
            this.TimerFPS.Interval = 1000;
            this.TimerFPS.Tick += new System.EventHandler(this.TimerFPS_Tick);
            // 
            // pbFiltered
            // 
            this.pbFiltered.BackColor = System.Drawing.Color.Transparent;
            this.pbFiltered.Location = new System.Drawing.Point(13, 45);
            this.pbFiltered.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbFiltered.Name = "pbFiltered";
            this.pbFiltered.Size = new System.Drawing.Size(187, 164);
            this.pbFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltered.TabIndex = 9;
            this.pbFiltered.TabStop = false;
            // 
            // tbhlow
            // 
            this.tbhlow.Location = new System.Drawing.Point(9, 20);
            this.tbhlow.Maximum = 255;
            this.tbhlow.Name = "tbhlow";
            this.tbhlow.Size = new System.Drawing.Size(118, 45);
            this.tbhlow.TabIndex = 10;
            this.tbhlow.TickFrequency = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbllowv);
            this.groupBox1.Controls.Add(this.Lbllows);
            this.groupBox1.Controls.Add(this.Lbllowh);
            this.groupBox1.Controls.Add(this.tbvlow);
            this.groupBox1.Controls.Add(this.tbslow);
            this.groupBox1.Controls.Add(this.tbhlow);
            this.groupBox1.Location = new System.Drawing.Point(934, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "lower";
            // 
            // Lbllowv
            // 
            this.Lbllowv.AutoSize = true;
            this.Lbllowv.Location = new System.Drawing.Point(132, 106);
            this.Lbllowv.Name = "Lbllowv";
            this.Lbllowv.Size = new System.Drawing.Size(14, 13);
            this.Lbllowv.TabIndex = 16;
            this.Lbllowv.Text = "0";
            // 
            // Lbllows
            // 
            this.Lbllows.AutoSize = true;
            this.Lbllows.Location = new System.Drawing.Point(132, 68);
            this.Lbllows.Name = "Lbllows";
            this.Lbllows.Size = new System.Drawing.Size(14, 13);
            this.Lbllows.TabIndex = 15;
            this.Lbllows.Text = "0";
            // 
            // Lbllowh
            // 
            this.Lbllowh.AutoSize = true;
            this.Lbllowh.Location = new System.Drawing.Point(133, 35);
            this.Lbllowh.Name = "Lbllowh";
            this.Lbllowh.Size = new System.Drawing.Size(14, 13);
            this.Lbllowh.TabIndex = 14;
            this.Lbllowh.Text = "0";
            // 
            // tbvlow
            // 
            this.tbvlow.Location = new System.Drawing.Point(8, 97);
            this.tbvlow.Maximum = 255;
            this.tbvlow.Name = "tbvlow";
            this.tbvlow.Size = new System.Drawing.Size(118, 45);
            this.tbvlow.TabIndex = 13;
            this.tbvlow.TickFrequency = 16;
            // 
            // tbslow
            // 
            this.tbslow.Location = new System.Drawing.Point(8, 56);
            this.tbslow.Maximum = 255;
            this.tbslow.Name = "tbslow";
            this.tbslow.Size = new System.Drawing.Size(118, 45);
            this.tbslow.TabIndex = 12;
            this.tbslow.TickFrequency = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lblupv);
            this.groupBox2.Controls.Add(this.Lblups);
            this.groupBox2.Controls.Add(this.Lbluph);
            this.groupBox2.Controls.Add(this.tbvup);
            this.groupBox2.Controls.Add(this.tbsup);
            this.groupBox2.Controls.Add(this.tbhup);
            this.groupBox2.Location = new System.Drawing.Point(934, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 152);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "upper";
            // 
            // Lblupv
            // 
            this.Lblupv.AutoSize = true;
            this.Lblupv.Location = new System.Drawing.Point(132, 109);
            this.Lblupv.Name = "Lblupv";
            this.Lblupv.Size = new System.Drawing.Size(14, 13);
            this.Lblupv.TabIndex = 16;
            this.Lblupv.Text = "0";
            // 
            // Lblups
            // 
            this.Lblups.AutoSize = true;
            this.Lblups.Location = new System.Drawing.Point(132, 68);
            this.Lblups.Name = "Lblups";
            this.Lblups.Size = new System.Drawing.Size(14, 13);
            this.Lblups.TabIndex = 15;
            this.Lblups.Text = "0";
            // 
            // Lbluph
            // 
            this.Lbluph.AutoSize = true;
            this.Lbluph.Location = new System.Drawing.Point(133, 35);
            this.Lbluph.Name = "Lbluph";
            this.Lbluph.Size = new System.Drawing.Size(14, 13);
            this.Lbluph.TabIndex = 14;
            this.Lbluph.Text = "0";
            // 
            // tbvup
            // 
            this.tbvup.Location = new System.Drawing.Point(8, 97);
            this.tbvup.Maximum = 255;
            this.tbvup.Name = "tbvup";
            this.tbvup.Size = new System.Drawing.Size(118, 45);
            this.tbvup.TabIndex = 13;
            this.tbvup.TickFrequency = 16;
            // 
            // tbsup
            // 
            this.tbsup.Location = new System.Drawing.Point(8, 56);
            this.tbsup.Maximum = 255;
            this.tbsup.Name = "tbsup";
            this.tbsup.Size = new System.Drawing.Size(118, 45);
            this.tbsup.TabIndex = 12;
            this.tbsup.TickFrequency = 16;
            // 
            // tbhup
            // 
            this.tbhup.Location = new System.Drawing.Point(9, 20);
            this.tbhup.Maximum = 255;
            this.tbhup.Name = "tbhup";
            this.tbhup.Size = new System.Drawing.Size(118, 45);
            this.tbhup.TabIndex = 10;
            this.tbhup.TickFrequency = 16;
            // 
            // lblrectx
            // 
            this.lblrectx.AutoSize = true;
            this.lblrectx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblrectx.Location = new System.Drawing.Point(931, 392);
            this.lblrectx.Name = "lblrectx";
            this.lblrectx.Size = new System.Drawing.Size(74, 13);
            this.lblrectx.TabIndex = 13;
            this.lblrectx.Text = "rectangle x:";
            // 
            // lblrecty
            // 
            this.lblrecty.AutoSize = true;
            this.lblrecty.Location = new System.Drawing.Point(931, 420);
            this.lblrecty.Name = "lblrecty";
            this.lblrecty.Size = new System.Drawing.Size(78, 13);
            this.lblrecty.TabIndex = 14;
            this.lblrecty.Text = "rectangle y :";
            // 
            // lbCommPorts
            // 
            this.lbCommPorts.FormattingEnabled = true;
            this.lbCommPorts.Location = new System.Drawing.Point(13, 254);
            this.lbCommPorts.Name = "lbCommPorts";
            this.lbCommPorts.Size = new System.Drawing.Size(120, 82);
            this.lbCommPorts.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comm Ports List";
            // 
            // Btncom
            // 
            this.Btncom.AutoSize = true;
            this.Btncom.Location = new System.Drawing.Point(15, 366);
            this.Btncom.Name = "Btncom";
            this.Btncom.Size = new System.Drawing.Size(78, 17);
            this.Btncom.TabIndex = 17;
            this.Btncom.TabStop = true;
            this.Btncom.Text = "Computer";
            this.Btncom.UseVisualStyleBackColor = true;
            // 
            // Btnmanual
            // 
            this.Btnmanual.AutoSize = true;
            this.Btnmanual.Location = new System.Drawing.Point(15, 392);
            this.Btnmanual.Name = "Btnmanual";
            this.Btnmanual.Size = new System.Drawing.Size(66, 17);
            this.Btnmanual.TabIndex = 18;
            this.Btnmanual.TabStop = true;
            this.Btnmanual.Text = "Manual";
            this.Btnmanual.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(65)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 548);
            this.Controls.Add(this.Btnmanual);
            this.Controls.Add(this.Btncom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCommPorts);
            this.Controls.Add(this.lblrecty);
            this.Controls.Add(this.lblrectx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbFiltered);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.PBPreview);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Control Room";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhlow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbvlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbslow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbvup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbhup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConnect;
        internal System.Windows.Forms.PictureBox PBPreview;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Timer TimerFPS;
        internal System.Windows.Forms.PictureBox pbFiltered;
        private System.Windows.Forms.TrackBar tbhlow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbvlow;
        private System.Windows.Forms.TrackBar tbslow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbvup;
        private System.Windows.Forms.TrackBar tbsup;
        private System.Windows.Forms.TrackBar tbhup;
        private System.Windows.Forms.Label Lbllowv;
        private System.Windows.Forms.Label Lbllows;
        private System.Windows.Forms.Label Lbllowh;
        private System.Windows.Forms.Label Lblupv;
        private System.Windows.Forms.Label Lblups;
        private System.Windows.Forms.Label Lbluph;
        private System.Windows.Forms.Label lblrectx;
        private System.Windows.Forms.Label lblrecty;
        private System.Windows.Forms.ListBox lbCommPorts;
        private System.Windows.Forms.ToolStripMenuItem scanPortsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Btncom;
        private System.Windows.Forms.RadioButton Btnmanual;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
    }
}

