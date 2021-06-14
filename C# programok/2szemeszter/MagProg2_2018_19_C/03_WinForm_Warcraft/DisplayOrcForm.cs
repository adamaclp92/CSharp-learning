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
    public partial class DisplayOrcForm : Form
    {
        Orc orc;

        public DisplayOrcForm(uint Id)
        {
            InitializeComponent();

            orc = MainWindow.Thral[Id];
            DisplayData();
        }

        public void DisplayData()
        {
            lblNameData.Text = orc.Name;
            lblHealthData.Text = orc.Health.ToString();
            lblDeadData.Text = orc.Dead ? "Yes" : "No";
            lblDamageData.Text = orc.Damage.ToString();
            lblCouncilorData.Text = orc.Councilor ? "Yes" : "No";

            string[] files = Directory.GetFiles(Settings.Default.DirectoryImages);
            string fileName = string.Empty;
            foreach (string f in files)
            {
                if (f.Contains("IMG_" + orc.Id + "."))
                    fileName = f;
            }
            if (fileName != string.Empty)
            {
                Image image = Image.FromFile(fileName);
                pbProfilePicture.Image = image;
            }
        }
    }
}
