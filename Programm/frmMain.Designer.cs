namespace FR_GA
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl_Images = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxOutputImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxInputImage = new System.Windows.Forms.PictureBox();
            this.pnl_controls = new System.Windows.Forms.TableLayoutPanel();
            this.CrossProbability = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.Generations = new System.Windows.Forms.TextBox();
            this.Individuals = new System.Windows.Forms.TextBox();
            this.MutationProbability = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MutationValue = new System.Windows.Forms.TextBox();
            this.pnl_Images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).BeginInit();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Images
            // 
            this.pnl_Images.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Images.ColumnCount = 2;
            this.pnl_Images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Images.Controls.Add(this.pictureBoxOutputImage, 1, 0);
            this.pnl_Images.Controls.Add(this.pictureBoxInputImage, 0, 0);
            this.pnl_Images.Location = new System.Drawing.Point(12, 12);
            this.pnl_Images.Name = "pnl_Images";
            this.pnl_Images.RowCount = 1;
            this.pnl_Images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Images.Size = new System.Drawing.Size(1287, 560);
            this.pnl_Images.TabIndex = 0;
            // 
            // pictureBoxOutputImage
            // 
            this.pictureBoxOutputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOutputImage.Location = new System.Drawing.Point(646, 3);
            this.pictureBoxOutputImage.Name = "pictureBoxOutputImage";
            this.pictureBoxOutputImage.Size = new System.Drawing.Size(638, 554);
            this.pictureBoxOutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOutputImage.TabIndex = 1;
            this.pictureBoxOutputImage.TabStop = false;
            // 
            // pictureBoxInputImage
            // 
            this.pictureBoxInputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInputImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxInputImage.Name = "pictureBoxInputImage";
            this.pictureBoxInputImage.Size = new System.Drawing.Size(637, 554);
            this.pictureBoxInputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInputImage.TabIndex = 0;
            this.pictureBoxInputImage.TabStop = false;
            // 
            // pnl_controls
            // 
            this.pnl_controls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_controls.ColumnCount = 7;
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5109F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.99377F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45794F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85047F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.46106F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.39564F));
            this.pnl_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_controls.Controls.Add(this.CrossProbability, 4, 0);
            this.pnl_controls.Controls.Add(this.btnInput, 0, 0);
            this.pnl_controls.Controls.Add(this.btnProcess, 0, 1);
            this.pnl_controls.Controls.Add(this.Generations, 2, 0);
            this.pnl_controls.Controls.Add(this.Individuals, 2, 1);
            this.pnl_controls.Controls.Add(this.MutationProbability, 4, 1);
            this.pnl_controls.Controls.Add(this.label1, 1, 0);
            this.pnl_controls.Controls.Add(this.label2, 1, 1);
            this.pnl_controls.Controls.Add(this.label3, 3, 0);
            this.pnl_controls.Controls.Add(this.label4, 3, 1);
            this.pnl_controls.Controls.Add(this.label5, 5, 1);
            this.pnl_controls.Controls.Add(this.MutationValue, 6, 1);
            this.pnl_controls.Location = new System.Drawing.Point(12, 591);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.RowCount = 2;
            this.pnl_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_controls.Size = new System.Drawing.Size(1284, 97);
            this.pnl_controls.TabIndex = 1;
            // 
            // CrossProbability
            // 
            this.CrossProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrossProbability.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossProbability.Location = new System.Drawing.Point(789, 3);
            this.CrossProbability.Name = "CrossProbability";
            this.CrossProbability.Size = new System.Drawing.Size(159, 34);
            this.CrossProbability.TabIndex = 4;
            this.CrossProbability.Enter += new System.EventHandler(this.Control_Enter);
            this.CrossProbability.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInput.FlatAppearance.BorderSize = 3;
            this.btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.ForeColor = System.Drawing.Color.Black;
            this.btnInput.Location = new System.Drawing.Point(3, 3);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(177, 42);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Select Image";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            this.btnInput.Enter += new System.EventHandler(this.Control_Enter);
            this.btnInput.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcess.FlatAppearance.BorderSize = 3;
            this.btnProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(3, 51);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(177, 43);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "FAGA";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.btnProcess.Enter += new System.EventHandler(this.Control_Enter);
            this.btnProcess.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // Generations
            // 
            this.Generations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generations.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generations.Location = new System.Drawing.Point(398, 3);
            this.Generations.Name = "Generations";
            this.Generations.Size = new System.Drawing.Size(148, 34);
            this.Generations.TabIndex = 2;
            this.Generations.Enter += new System.EventHandler(this.Control_Enter);
            this.Generations.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // Individuals
            // 
            this.Individuals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Individuals.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Individuals.Location = new System.Drawing.Point(398, 51);
            this.Individuals.Name = "Individuals";
            this.Individuals.Size = new System.Drawing.Size(148, 34);
            this.Individuals.TabIndex = 3;
            this.Individuals.Enter += new System.EventHandler(this.Control_Enter);
            this.Individuals.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // MutationProbability
            // 
            this.MutationProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MutationProbability.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationProbability.Location = new System.Drawing.Point(789, 51);
            this.MutationProbability.Name = "MutationProbability";
            this.MutationProbability.Size = new System.Drawing.Size(159, 34);
            this.MutationProbability.TabIndex = 5;
            this.MutationProbability.Enter += new System.EventHandler(this.Control_Enter);
            this.MutationProbability.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Individuals";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(552, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cross Probability";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(552, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 49);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mutation Probability";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(954, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 49);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mutation Value";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MutationValue
            // 
            this.MutationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MutationValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationValue.Location = new System.Drawing.Point(1114, 51);
            this.MutationValue.Name = "MutationValue";
            this.MutationValue.Size = new System.Drawing.Size(167, 34);
            this.MutationValue.TabIndex = 6;
            this.MutationValue.Enter += new System.EventHandler(this.Control_Enter);
            this.MutationValue.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1311, 700);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.pnl_Images);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACE RECOGNITION using GENETIC ALGORITHM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).EndInit();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnl_Images;
        private System.Windows.Forms.PictureBox pictureBoxInputImage;
        private System.Windows.Forms.PictureBox pictureBoxOutputImage;
        private System.Windows.Forms.TableLayoutPanel pnl_controls;
        private System.Windows.Forms.TextBox Generations;
        private System.Windows.Forms.TextBox Individuals;
        private System.Windows.Forms.TextBox MutationValue;
        private System.Windows.Forms.TextBox MutationProbability;
        private System.Windows.Forms.TextBox CrossProbability;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

