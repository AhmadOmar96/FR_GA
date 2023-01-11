namespace FR_GA.Programm
{
    partial class frmShowResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowResult));
            this.pictureBoxShowResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxShowResult
            // 
            this.pictureBoxShowResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShowResult.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShowResult.Name = "pictureBoxShowResult";
            this.pictureBoxShowResult.Size = new System.Drawing.Size(818, 719);
            this.pictureBoxShowResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxShowResult.TabIndex = 0;
            this.pictureBoxShowResult.TabStop = false;
            // 
            // frmShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(818, 719);
            this.Controls.Add(this.pictureBoxShowResult);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOW RESULT";
            this.Load += new System.EventHandler(this.frmShowResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShowResult;
    }
}