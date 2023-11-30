namespace test1
{
    partial class poziomy
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
            this.lv1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.level2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lv1.Location = new System.Drawing.Point(43, 96);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(233, 213);
            this.lv1.TabIndex = 0;
            this.lv1.Text = "Poziom 1";
            this.lv1.UseVisualStyleBackColor = true;
            this.lv1.Click += new System.EventHandler(this.lv1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz poziom";
            // 
            // level2
            // 
            this.level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.level2.Location = new System.Drawing.Point(309, 96);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(233, 213);
            this.level2.TabIndex = 2;
            this.level2.Text = "Poziom 2";
            this.level2.UseVisualStyleBackColor = true;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.level3.Location = new System.Drawing.Point(575, 96);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(233, 213);
            this.level3.TabIndex = 3;
            this.level3.Text = "Poziom 3";
            this.level3.UseVisualStyleBackColor = true;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // poziomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv1);
            this.Name = "poziomy";
            this.Text = "Super Racing Sim - wybór poziomu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level3;
    }
}