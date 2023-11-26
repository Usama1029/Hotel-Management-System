
namespace SElabProject
{
    partial class booking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitlereservation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textroom = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lbltitlereservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 100);
            this.panel1.TabIndex = 33;
            // 
            // lbltitlereservation
            // 
            this.lbltitlereservation.AutoSize = true;
            this.lbltitlereservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbltitlereservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlereservation.ForeColor = System.Drawing.Color.White;
            this.lbltitlereservation.Location = new System.Drawing.Point(471, 36);
            this.lbltitlereservation.Name = "lbltitlereservation";
            this.lbltitlereservation.Size = new System.Drawing.Size(337, 29);
            this.lbltitlereservation.TabIndex = 2;
            this.lbltitlereservation.Text = "Admin Menu >> Book Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select Room No :";
            // 
            // textroom
            // 
            this.textroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textroom.Location = new System.Drawing.Point(376, 516);
            this.textroom.Name = "textroom";
            this.textroom.Size = new System.Drawing.Size(451, 39);
            this.textroom.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Five Star ",
            "Four Star",
            "Three Star"});
            this.comboBox1.Location = new System.Drawing.Point(376, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(451, 34);
            this.comboBox1.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1034, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 44;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(376, 599);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(451, 56);
            this.add.TabIndex = 43;
            this.add.Text = "Book Room";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txtbill
            // 
            this.txtbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill.Location = new System.Drawing.Point(376, 454);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(451, 39);
            this.txtbill.TabIndex = 42;
            // 
            // txtdays
            // 
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdays.Location = new System.Drawing.Point(376, 384);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(451, 39);
            this.txtdays.TabIndex = 41;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(376, 243);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(451, 39);
            this.txtpass.TabIndex = 40;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(376, 169);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(451, 39);
            this.txtname.TabIndex = 39;
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.Location = new System.Drawing.Point(138, 454);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(195, 32);
            this.lblmobile.TabIndex = 38;
            this.lblmobile.Text = "Bill Per Night :";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(158, 387);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(169, 32);
            this.lbldays.TabIndex = 37;
            this.lbldays.Text = "No. of Days:";
            // 
            // lblroom
            // 
            this.lblroom.AutoSize = true;
            this.lblroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroom.Location = new System.Drawing.Point(138, 320);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(185, 32);
            this.lblroom.TabIndex = 36;
            this.lblroom.Text = "Select Room:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(169, 250);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(154, 32);
            this.lblpass.TabIndex = 35;
            this.lblpass.Text = "Password :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(208, 169);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 32);
            this.lblname.TabIndex = 34;
            this.lblname.Text = "  Name :";
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textroom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.lbldays);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.Name = "booking";
            this.Text = "booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitlereservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textroom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblname;
    }
}