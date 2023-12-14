namespace test1
{
    partial class lv3
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
            this.samochod = new System.Windows.Forms.Button();
            this.okno_glowne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.okno_glowne)).BeginInit();
            this.SuspendLayout();
            // 
            // samochod
            // 
            this.samochod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.samochod.Location = new System.Drawing.Point(12, 399);
            this.samochod.Name = "samochod";
            this.samochod.Size = new System.Drawing.Size(50, 50);
            this.samochod.TabIndex = 0;
            this.samochod.UseVisualStyleBackColor = false;
            this.samochod.Click += new System.EventHandler(this.samochod_Click);
            // 
            // okno_glowne
            // 
            this.okno_glowne.BackColor = System.Drawing.SystemColors.Control;
            this.okno_glowne.Location = new System.Drawing.Point(0, 0);
            this.okno_glowne.Name = "okno_glowne";
            this.okno_glowne.Size = new System.Drawing.Size(100, 50);
            this.okno_glowne.TabIndex = 1;
            this.okno_glowne.TabStop = false;
            this.okno_glowne.Click += new System.EventHandler(this.okno_glowne_Click);
            this.okno_glowne.Paint += new System.Windows.Forms.PaintEventHandler(this.okno_glowne_Paint_1);
            this.okno_glowne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.okno_glowne_MouseMove);
            // 
            // lv3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.okno_glowne);
            this.Controls.Add(this.samochod);
            this.KeyPreview = true;
            this.Name = "lv3";
            this.Text = "lv3";
            this.Load += new System.EventHandler(this.lv3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.lv3_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv3_KeyDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lv3_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.okno_glowne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button samochod;
        private System.Windows.Forms.PictureBox okno_glowne;
    }
}