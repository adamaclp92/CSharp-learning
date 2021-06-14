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

namespace beadandowinform
{
    public partial class Form2 : Form
    {
        Form opener;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uvegkontener kontener = new uvegkontener();
            StreamReader file = new StreamReader("Arlista.txt");

            while (!file.EndOfStream)
            {
 
                string line = file.ReadLine();
                string[] data = line.Split(';');

                uvegek uj = new uvegek((Uvegfajtak)Enum.Parse(typeof(Uvegfajtak), data[0]), int.Parse(data[1]));
                        kontener.Hozzaad(uj);



                
            }


            for (int i = 0; i < kontener.uvegfajtakszama(); i++)
            {
                string item = string.Format("{0}: {1} Ft", kontener[i].Uvegfajta.ToString(), kontener[i].Uvegar.ToString());
                listBox1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
