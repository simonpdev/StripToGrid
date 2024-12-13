namespace StripToGrid
{
    partial class frmBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdImageSelect = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.picBaseImage = new System.Windows.Forms.PictureBox();
            this.numCellSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGrid = new System.Windows.Forms.Button();
            this.picGridOutput = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.lblBaseImage = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.sfdOutputImage = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGridOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImageSelect
            // 
            this.ofdImageSelect.DefaultExt = "png";
            this.ofdImageSelect.Filter = "Images (*.png)|*.png";
            this.ofdImageSelect.Title = "Select an Image";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(639, 274);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(265, 56);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "OPEN IMAGE STRIP";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // picBaseImage
            // 
            this.picBaseImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBaseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBaseImage.Location = new System.Drawing.Point(51, 44);
            this.picBaseImage.Margin = new System.Windows.Forms.Padding(2);
            this.picBaseImage.Name = "picBaseImage";
            this.picBaseImage.Size = new System.Drawing.Size(494, 85);
            this.picBaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBaseImage.TabIndex = 1;
            this.picBaseImage.TabStop = false;
            // 
            // numCellSize
            // 
            this.numCellSize.Location = new System.Drawing.Point(153, 43);
            this.numCellSize.Margin = new System.Windows.Forms.Padding(2);
            this.numCellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCellSize.Name = "numCellSize";
            this.numCellSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numCellSize.Size = new System.Drawing.Size(90, 20);
            this.numCellSize.TabIndex = 1;
            this.numCellSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCellSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cell Size (px)";
            // 
            // btnCreateGrid
            // 
            this.btnCreateGrid.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCreateGrid.FlatAppearance.BorderSize = 10;
            this.btnCreateGrid.Location = new System.Drawing.Point(639, 334);
            this.btnCreateGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateGrid.Name = "btnCreateGrid";
            this.btnCreateGrid.Size = new System.Drawing.Size(265, 56);
            this.btnCreateGrid.TabIndex = 2;
            this.btnCreateGrid.Text = "CREATE GRID";
            this.btnCreateGrid.UseVisualStyleBackColor = true;
            this.btnCreateGrid.Click += new System.EventHandler(this.btnCreateGrid_Click);
            // 
            // picGridOutput
            // 
            this.picGridOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGridOutput.Location = new System.Drawing.Point(51, 213);
            this.picGridOutput.Margin = new System.Windows.Forms.Padding(2);
            this.picGridOutput.Name = "picGridOutput";
            this.picGridOutput.Size = new System.Drawing.Size(494, 237);
            this.picGridOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGridOutput.TabIndex = 5;
            this.picGridOutput.TabStop = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(639, 394);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(265, 56);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "SAVE IMAGE";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Columns";
            // 
            // numColumns
            // 
            this.numColumns.Location = new System.Drawing.Point(20, 43);
            this.numColumns.Margin = new System.Windows.Forms.Padding(2);
            this.numColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numColumns.Size = new System.Drawing.Size(90, 20);
            this.numColumns.TabIndex = 0;
            this.numColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numColumns.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.numColumns);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.numCellSize);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grpSettings.Location = new System.Drawing.Point(639, 44);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(265, 93);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Output Grid Settings";
            // 
            // lblBaseImage
            // 
            this.lblBaseImage.AutoSize = true;
            this.lblBaseImage.Location = new System.Drawing.Point(48, 29);
            this.lblBaseImage.Name = "lblBaseImage";
            this.lblBaseImage.Size = new System.Drawing.Size(63, 13);
            this.lblBaseImage.TabIndex = 10;
            this.lblBaseImage.Text = "Base Image";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(48, 198);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(61, 13);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Grid Output";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(953, 494);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblBaseImage);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.picGridOutput);
            this.Controls.Add(this.btnCreateGrid);
            this.Controls.Add(this.picBaseImage);
            this.Controls.Add(this.btnSelectImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "StripToGrid";
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGridOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox picBaseImage;
        private System.Windows.Forms.NumericUpDown numCellSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGrid;
        private System.Windows.Forms.PictureBox picGridOutput;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label lblBaseImage;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.SaveFileDialog sfdOutputImage;
        private System.Windows.Forms.OpenFileDialog ofdImageSelect;
    }
}

