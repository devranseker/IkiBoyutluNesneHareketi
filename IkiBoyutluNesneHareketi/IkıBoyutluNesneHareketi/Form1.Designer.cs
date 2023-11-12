namespace IkıBoyutluNesneHareketi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Arabamiz = new System.Windows.Forms.PictureBox();
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            this.timerSag = new System.Windows.Forms.Timer(this.components);
            this.timerAsagı = new System.Windows.Forms.Timer(this.components);
            this.timerSol = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arabamiz)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(264, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(28, 220);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(574, 119);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(30, 220);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(279, 119);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(298, 29);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(282, 307);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(298, 32);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(882, 18);
            this.flowLayoutPanel9.TabIndex = 7;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(21, 429);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(12, 440);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(890, 18);
            this.flowLayoutPanel10.TabIndex = 8;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(12, 16);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(21, 429);
            this.flowLayoutPanel11.TabIndex = 9;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(873, 16);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(21, 429);
            this.flowLayoutPanel6.TabIndex = 10;
            // 
            // Arabamiz
            // 
            this.Arabamiz.Image = global::IkıBoyutluNesneHareketi.Properties.Resources.car;
            this.Arabamiz.Location = new System.Drawing.Point(95, 359);
            this.Arabamiz.Name = "Arabamiz";
            this.Arabamiz.Size = new System.Drawing.Size(66, 62);
            this.Arabamiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arabamiz.TabIndex = 11;
            this.Arabamiz.TabStop = false;
            // 
            // timerYukari
            // 
            this.timerYukari.Interval = 20;
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // timerSag
            // 
            this.timerSag.Interval = 20;
            this.timerSag.Tick += new System.EventHandler(this.timerSag_Tick);
            // 
            // timerAsagı
            // 
            this.timerAsagı.Interval = 20;
            this.timerAsagı.Tick += new System.EventHandler(this.timerAsagı_Tick);
            // 
            // timerSol
            // 
            this.timerSol.Interval = 20;
            this.timerSol.Tick += new System.EventHandler(this.timerSol_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(895, 457);
            this.Controls.Add(this.Arabamiz);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel11);
            this.Controls.Add(this.flowLayoutPanel10);
            this.Controls.Add(this.flowLayoutPanel9);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Arabamiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox Arabamiz;
        private System.Windows.Forms.Timer timerYukari;
        private System.Windows.Forms.Timer timerSag;
        private System.Windows.Forms.Timer timerAsagı;
        private System.Windows.Forms.Timer timerSol;
    }
}

