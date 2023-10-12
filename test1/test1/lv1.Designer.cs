namespace test1
{
    partial class lv1
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
            this.level1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level1.Location = new System.Drawing.Point(12, 12);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(810, 437);
            this.level1.TabIndex = 0;
            this.level1.TabStop = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            this.level1.Paint += new System.Windows.Forms.PaintEventHandler(this.level1_Paint);
            // 
            // lv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.level1);
            this.Name = "lv1";
            this.Text = "Super Racing Sim - poziom 1";
            this.Load += new System.EventHandler(this.lv1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox level1;
    }
}