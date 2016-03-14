﻿namespace CodemastersBinImage
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenBmp = new System.Windows.Forms.OpenFileDialog();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lvItems = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnImplode = new System.Windows.Forms.Button();
            this.btnExportBitmap = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(349, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(351, 387);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "ROM Files (*.bin)|*.bin|All Files (*.*)|*.*";
            this.dlgOpen.RestoreDirectory = true;
            this.dlgOpen.Title = "Select the game ROM...";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "bmp";
            this.dlgSave.Filter = "BMP Files (*.bmp)|*.bmp";
            this.dlgSave.RestoreDirectory = true;
            this.dlgSave.Title = "Where to save bitmap...";
            // 
            // dlgOpenBmp
            // 
            this.dlgOpenBmp.Filter = "BMP Files (*.bmp)|*.bmp";
            this.dlgOpenBmp.RestoreDirectory = true;
            this.dlgOpenBmp.Title = "Select Bitmap file...";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lvItems);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(349, 387);
            this.pnlLeft.TabIndex = 7;
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIndex,
            this.chOffset,
            this.chSize});
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(0, 82);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(349, 305);
            this.lvItems.TabIndex = 6;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            this.lvItems.Resize += new System.EventHandler(this.lvItems_Resize);
            // 
            // chIndex
            // 
            this.chIndex.Text = "#";
            this.chIndex.Width = 50;
            // 
            // chOffset
            // 
            this.chOffset.Text = "Offset";
            this.chOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOffset.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSize.Width = 100;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnImplode);
            this.pnlButtons.Controls.Add(this.btnExportBitmap);
            this.pnlButtons.Controls.Add(this.btnBrowse);
            this.pnlButtons.Controls.Add(this.tbPath);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(349, 82);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnImplode
            // 
            this.btnImplode.AutoSize = true;
            this.btnImplode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImplode.Location = new System.Drawing.Point(108, 41);
            this.btnImplode.Name = "btnImplode";
            this.btnImplode.Size = new System.Drawing.Size(115, 27);
            this.btnImplode.TabIndex = 6;
            this.btnImplode.Text = "Implode Bitmap";
            this.btnImplode.UseVisualStyleBackColor = true;
            this.btnImplode.Click += new System.EventHandler(this.btnImplode_Click);
            // 
            // btnExportBitmap
            // 
            this.btnExportBitmap.AutoSize = true;
            this.btnExportBitmap.Enabled = false;
            this.btnExportBitmap.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportBitmap.Location = new System.Drawing.Point(229, 41);
            this.btnExportBitmap.Name = "btnExportBitmap";
            this.btnExportBitmap.Size = new System.Drawing.Size(108, 27);
            this.btnExportBitmap.TabIndex = 5;
            this.btnExportBitmap.Text = "Export Bitmap";
            this.btnExportBitmap.UseVisualStyleBackColor = true;
            this.btnExportBitmap.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(14, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 27);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(14, 15);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(323, 20);
            this.tbPath.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 387);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pnlLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codemasters BinImage";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenBmp;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.ColumnHeader chOffset;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnImplode;
        private System.Windows.Forms.Button btnExportBitmap;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbPath;
    }
}
