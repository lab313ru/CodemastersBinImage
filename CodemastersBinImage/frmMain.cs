﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WinImploder;

namespace CodemastersBinImage
{
    public partial class frmMain : Form
    {
        byte[] rom = null;
        List<Tuple<int, int>> itemsList = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(dlgOpen.FileName)) return;

            tbPath.Text = dlgOpen.FileName;

            lvItems.Items.Clear();
            pbImage.Image = null;

            rom = File.ReadAllBytes(tbPath.Text);
            itemsList = ImploderWork.FindImploded(rom);

            if (itemsList == null) return;

            int i = 0;
            while (i < itemsList.Count)
            {
                Tuple<int, int> pair = itemsList[i];

                int offset = pair.Item1;
                int size = pair.Item2;

                byte[] data = new byte[size];
                Array.Copy(rom, offset, data, 0, size);

                BinImageData bid = new BinImageData(data);

                Bitmap bmp = bid.Image;
                if (bmp == null)
                {
                    itemsList.Remove(pair);
                    continue;
                }
                bmp.Dispose();

                string[] row = { i.ToString(), offset.ToString("X6"), size.ToString("X4") };
                var lvItem = new ListViewItem(row);
                lvItems.Items.Add(lvItem);

                i++;
            }

            if (lvItems.Items == null) return;

            lvItems.Items[0].Focused = true;
            lvItems.Items[0].Selected = true;
            lvItems.Select();
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            if (lvItems.SelectedIndices.Count == 0) return;
            if (rom == null) return;
            if (itemsList == null) return;

            int index = lvItems.SelectedIndices[0];
            int offset = itemsList[index].Item1;
            int size = itemsList[index].Item2;

            dlgSave.FileName = Path.GetFileName(Path.ChangeExtension(tbPath.Text, string.Format(".{0:000}_{1:X6}.bmp", index, offset)));
            if (dlgSave.ShowDialog() != DialogResult.OK) return;

            byte[] data = new byte[size];
            Array.Copy(rom, offset, data, 0, size);

            BinImageData bid = new BinImageData(data);
            Bitmap bmp = bid.Image;

            if (bmp == null) return;

            bmp.Save(dlgSave.FileName, ImageFormat.Bmp);
            MessageBox.Show(string.Format("{0}{1}File: \"{2}\".",
                "File successfully converted to bitmap!",
                Environment.NewLine,
                Path.GetFileName(dlgSave.FileName)
                ), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bmp.Dispose();
        }

        private void btnImplode_Click(object sender, System.EventArgs e)
        {
            if (lvItems.SelectedIndices.Count == 0) return;
            if (rom == null) return;
            if (itemsList == null) return;

            int index = lvItems.SelectedIndices[0];
            int offset = itemsList[index].Item1;

            dlgOpenBmp.FileName = Path.GetFileName(Path.ChangeExtension(tbPath.Text, string.Format(".{0:000}_{1:X6}.bmp", index, offset)));
            if (dlgOpenBmp.ShowDialog() != DialogResult.OK) return;

            BinImageData bid = BinImageData.FromFile(dlgOpenBmp.FileName);

            if (bid == null) return;
            Bitmap bmp = bid.Image;

            if (bmp == null) return;
            bmp.Dispose();

            string fileName = Path.ChangeExtension(dlgOpenBmp.FileName, ".imp.bin");
            File.WriteAllBytes(fileName, bid.Data);

            MessageBox.Show(string.Format("{0}{1}File: \"{2}\".",
                "File successfully converted to binary data!",
                Environment.NewLine,
                Path.GetFileName(fileName)
                ), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvItems.SelectedIndices.Count == 0) return;
            if (rom == null) return;
            if (itemsList == null) return;

            btnExportBitmap.Enabled = false;

            int index = lvItems.SelectedIndices[0];
            int offset = itemsList[index].Item1;
            int size = itemsList[index].Item2;

            byte[] data = new byte[size];
            Array.Copy(rom, offset, data, 0, size);

            BinImageData bid = new BinImageData(data);

            Bitmap bmp = bid.Image;

            if (bmp != null)
            {
                pbImage.Image = bmp;

                btnExportBitmap.Enabled = true;
            }
        }

        private void lvItems_Resize(object sender, EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SizeLastColumn(lvItems);
        }
    }
}