namespace GrammerApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bericht = new System.Windows.Forms.Button();
            this.Proband = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Visualisierung = new System.Windows.Forms.Button();
            this.Sensoren = new System.Windows.Forms.Button();
            this.Teststeurung = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Bericht);
            this.panel1.Controls.Add(this.Proband);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 211);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Bericht
            // 
            this.Bericht.BackColor = System.Drawing.Color.White;
            this.Bericht.Location = new System.Drawing.Point(1421, 144);
            this.Bericht.Name = "Bericht";
            this.Bericht.Size = new System.Drawing.Size(195, 63);
            this.Bericht.TabIndex = 3;
            this.Bericht.Text = "Bericht";
            this.Bericht.UseVisualStyleBackColor = false;
            this.Bericht.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Proband
            // 
            this.Proband.BackColor = System.Drawing.Color.White;
            this.Proband.Location = new System.Drawing.Point(1212, 144);
            this.Proband.Name = "Proband";
            this.Proband.Size = new System.Drawing.Size(203, 63);
            this.Proband.TabIndex = 2;
            this.Proband.Text = "Proband";
            this.Proband.UseVisualStyleBackColor = false;
            this.Proband.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.White;
            this.Dashboard.Location = new System.Drawing.Point(1012, 144);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(194, 63);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.Visualisierung);
            this.panel2.Controls.Add(this.Sensoren);
            this.panel2.Controls.Add(this.Teststeurung);
            this.panel2.Location = new System.Drawing.Point(3, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 634);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Visualisierung
            // 
            this.Visualisierung.Location = new System.Drawing.Point(9, 334);
            this.Visualisierung.Name = "Visualisierung";
            this.Visualisierung.Size = new System.Drawing.Size(287, 74);
            this.Visualisierung.TabIndex = 2;
            this.Visualisierung.Text = "Visualisierung";
            this.Visualisierung.UseVisualStyleBackColor = true;
            // 
            // Sensoren
            // 
            this.Sensoren.Location = new System.Drawing.Point(9, 205);
            this.Sensoren.Name = "Sensoren";
            this.Sensoren.Size = new System.Drawing.Size(287, 76);
            this.Sensoren.TabIndex = 1;
            this.Sensoren.Text = "Sensoren";
            this.Sensoren.UseVisualStyleBackColor = true;
            // 
            // Teststeurung
            // 
            this.Teststeurung.Location = new System.Drawing.Point(9, 75);
            this.Teststeurung.Name = "Teststeurung";
            this.Teststeurung.Size = new System.Drawing.Size(287, 71);
            this.Teststeurung.TabIndex = 0;
            this.Teststeurung.Text = "Teststeurung";
            this.Teststeurung.UseVisualStyleBackColor = true;
            this.Teststeurung.Click += new System.EventHandler(this.Teststeurung_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 924);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Bericht;
        private System.Windows.Forms.Button Proband;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sensoren;
        private System.Windows.Forms.Button Teststeurung;
        private System.Windows.Forms.Button Visualisierung;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}