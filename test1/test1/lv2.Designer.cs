namespace test1
{
    partial class lv2
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
            this.okno_glowne = new System.Windows.Forms.PictureBox();
            this.samochod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.okno_glowne)).BeginInit();
            this.SuspendLayout();
            // 
            // okno_glowne
            // 
            this.okno_glowne.Location = new System.Drawing.Point(2, -1);
            this.okno_glowne.Name = "okno_glowne";
            this.okno_glowne.Size = new System.Drawing.Size(100, 50);
            this.okno_glowne.TabIndex = 1;
            this.okno_glowne.TabStop = false;
            this.okno_glowne.Paint += new System.Windows.Forms.PaintEventHandler(this.okno_glowne_Paint);
            this.okno_glowne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.okno_glowne_MouseMove);
            // 
            // samochod
            // 
            this.samochod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.samochod.Location = new System.Drawing.Point(705, 366);
            this.samochod.Name = "samochod";
            this.samochod.Size = new System.Drawing.Size(40, 60);
            this.samochod.TabIndex = 2;
            this.samochod.UseVisualStyleBackColor = false;
            // 
            // lv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.samochod);
            this.Controls.Add(this.okno_glowne);
            this.KeyPreview = true;
            this.Name = "lv2";
            this.Text = "Super Racing Sim - Poziom 2";
            this.Load += new System.EventHandler(this.lv2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv2_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lv2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.okno_glowne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox okno_glowne;
        private System.Windows.Forms.Button samochod;
    }
}