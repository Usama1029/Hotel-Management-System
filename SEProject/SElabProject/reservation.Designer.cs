
namespace SElabProject
{
    partial class reservation
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
            this.panelreservation = new System.Windows.Forms.Panel();
            this.lbltitlereservation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelreservation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelreservation
            // 
            this.panelreservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelreservation.Controls.Add(this.lbltitlereservation);
            this.panelreservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelreservation.Location = new System.Drawing.Point(0, 0);
            this.panelreservation.Name = "panelreservation";
            this.panelreservation.Size = new System.Drawing.Size(1282, 100);
            this.panelreservation.TabIndex = 0;
            // 
            // lbltitlereservation
            // 
            this.lbltitlereservation.AutoSize = true;
            this.lbltitlereservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbltitlereservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlereservation.ForeColor = System.Drawing.Color.White;
            this.lbltitlereservation.Location = new System.Drawing.Point(497, 29);
            this.lbltitlereservation.Name = "lbltitlereservation";
            this.lbltitlereservation.Size = new System.Drawing.Size(340, 29);
            this.lbltitlereservation.TabIndex = 1;
            this.lbltitlereservation.Text = "Admin Menu >> Reservation";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 528);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(202, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 528);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 528);
            this.panel3.TabIndex = 3;
            this.panel3.UseWaitCursor = true;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelreservation);
            this.Name = "reservation";
            this.Text = "reservation";
            this.Load += new System.EventHandler(this.reservation_Load);
            this.panelreservation.ResumeLayout(false);
            this.panelreservation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelreservation;
        private System.Windows.Forms.Label lbltitlereservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}