namespace videocapture
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNGotIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Self Driving Car!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(74, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "How to use:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(74, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 140);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(493, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Controls:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(457, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 100);
            this.label6.TabIndex = 5;
            this.label6.Text = "--> Use the arrow keys to drive the car\r\n--> \"L\" turns the lights on\r\n--> \"O\" tur" +
    "ns them off\r\n--> when you want to take back control\r\n      of the car just click" +
    " manual";
            // 
            // BTNGotIt
            // 
            this.BTNGotIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGotIt.Location = new System.Drawing.Point(357, 381);
            this.BTNGotIt.Name = "BTNGotIt";
            this.BTNGotIt.Size = new System.Drawing.Size(94, 35);
            this.BTNGotIt.TabIndex = 6;
            this.BTNGotIt.Text = "Got It!";
            this.BTNGotIt.UseVisualStyleBackColor = true;
            this.BTNGotIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(65)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNGotIt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNGotIt;
    }
}