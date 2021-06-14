using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_WinForm_Warcraft
{
    public partial class AddOrcForm : Form
    {
        public AddOrcForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainWindow.Thral.AddOrc(tbName.Text,
                (int)nudHealth.Value,
                (int)nudDamage.Value,
                cbCouncilor.Checked);

            if (tbImage.Text != string.Empty)
            {
                uint Id = MainWindow.Thral.Orcs.Last().Id;
                string ext = tbImage.Text.Split('.').Last();
                string fileName = string.Format("IMG_{0}.{1}", Id, ext);
                File.Copy(tbImage.Text,
                    Path.Combine(Settings.Default.DirectoryImages, fileName),
                    true);
            }

            MessageBox.Show("Save successful!");
            this.Close();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImage.Text = openFileDialog.FileName;
            }
        }
    }
}
