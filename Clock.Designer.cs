namespace Clock
{
    partial class Clock
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
            this.lblUnix = new System.Windows.Forms.Label();
            this.lblAestTime = new System.Windows.Forms.Label();
            this.lblGmtTime = new System.Windows.Forms.Label();
            this.lblUnixTime = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblAest = new System.Windows.Forms.Label();
            this.lblGmt = new System.Windows.Forms.Label();
            this.tmrTimeUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUnix
            // 
            this.lblUnix.AutoSize = true;
            this.lblUnix.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnix.Location = new System.Drawing.Point(192, 89);
            this.lblUnix.Name = "lblUnix";
            this.lblUnix.Size = new System.Drawing.Size(94, 37);
            this.lblUnix.TabIndex = 0;
            this.lblUnix.Text = "Unix:";
            // 
            // lblAestTime
            // 
            this.lblAestTime.AutoSize = true;
            this.lblAestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAestTime.Location = new System.Drawing.Point(292, 156);
            this.lblAestTime.Name = "lblAestTime";
            this.lblAestTime.Size = new System.Drawing.Size(240, 29);
            this.lblAestTime.TabIndex = 3;
            this.lblAestTime.Text = "01:00 am, 01/01/2000";
            // 
            // lblGmtTime
            // 
            this.lblGmtTime.AutoSize = true;
            this.lblGmtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmtTime.Location = new System.Drawing.Point(292, 221);
            this.lblGmtTime.Name = "lblGmtTime";
            this.lblGmtTime.Size = new System.Drawing.Size(240, 29);
            this.lblGmtTime.TabIndex = 4;
            this.lblGmtTime.Text = "01:00 am, 01/01/2000";
            // 
            // lblUnixTime
            // 
            this.lblUnixTime.AutoSize = true;
            this.lblUnixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnixTime.Location = new System.Drawing.Point(292, 95);
            this.lblUnixTime.Name = "lblUnixTime";
            this.lblUnixTime.Size = new System.Drawing.Size(130, 29);
            this.lblUnixTime.TabIndex = 5;
            this.lblUnixTime.Text = "000000000";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(238, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(142, 52);
            this.lblClock.TabIndex = 6;
            this.lblClock.Text = "Clock";
            // 
            // lblAest
            // 
            this.lblAest.AutoSize = true;
            this.lblAest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAest.Location = new System.Drawing.Point(171, 150);
            this.lblAest.Name = "lblAest";
            this.lblAest.Size = new System.Drawing.Size(115, 37);
            this.lblAest.TabIndex = 7;
            this.lblAest.Text = "AEST:";
            // 
            // lblGmt
            // 
            this.lblGmt.AutoSize = true;
            this.lblGmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmt.Location = new System.Drawing.Point(185, 215);
            this.lblGmt.Name = "lblGmt";
            this.lblGmt.Size = new System.Drawing.Size(101, 37);
            this.lblGmt.TabIndex = 8;
            this.lblGmt.Text = "GMT:";
            // 
            // tmrTimeUpdater
            // 
            this.tmrTimeUpdater.Enabled = true;
            this.tmrTimeUpdater.Interval = 1000;
            this.tmrTimeUpdater.Tick += new System.EventHandler(this.tmrTimeUpdater_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 305);
            this.Controls.Add(this.lblGmt);
            this.Controls.Add(this.lblAest);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblUnixTime);
            this.Controls.Add(this.lblGmtTime);
            this.Controls.Add(this.lblAestTime);
            this.Controls.Add(this.lblUnix);
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnix;
        private System.Windows.Forms.Label lblAestTime;
        private System.Windows.Forms.Label lblGmtTime;
        private System.Windows.Forms.Label lblUnixTime;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblAest;
        private System.Windows.Forms.Label lblGmt;
        private System.Windows.Forms.Timer tmrTimeUpdater;
    }
}

