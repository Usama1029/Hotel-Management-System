
namespace SElabProject
{
    partial class mealgrid
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
            this.dataGridmeal = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnorder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmeal)).BeginInit();
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
            this.lbltitlereservation.Size = new System.Drawing.Size(368, 29);
            this.lbltitlereservation.TabIndex = 2;
            this.lbltitlereservation.Text = "Customer Menu >> View Menu";
            // 
            // dataGridmeal
            // 
            this.dataGridmeal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridmeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridmeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu});
            this.dataGridmeal.Location = new System.Drawing.Point(-3, 103);
            this.dataGridmeal.Name = "dataGridmeal";
            this.dataGridmeal.RowHeadersWidth = 62;
            this.dataGridmeal.RowTemplate.Height = 28;
            this.dataGridmeal.Size = new System.Drawing.Size(1288, 418);
            this.dataGridmeal.TabIndex = 32;
            this.dataGridmeal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridmeal_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1123, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 56);
            this.button2.TabIndex = 35;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(538, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 56);
            this.button1.TabIndex = 34;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.MinimumWidth = 8;
            this.Menu.Name = "Menu";
            this.Menu.UseColumnTextForButtonValue = true;
            this.Menu.Width = 150;
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.White;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(880, 614);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(147, 56);
            this.btnorder.TabIndex = 36;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // mealgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 682);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridmeal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mealgrid";
            this.Text = "mealgrid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitlereservation;
        private System.Windows.Forms.DataGridView dataGridmeal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Menu;
        private System.Windows.Forms.Button btnorder;
    }
}