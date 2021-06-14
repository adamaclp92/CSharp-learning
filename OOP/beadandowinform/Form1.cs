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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 frm = new Form2(this);
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
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
            try
            {
                int[] tomb = new int[6] { int.Parse(textBox1.Text),
                                      int.Parse(textBox3.Text),
                                      int.Parse(textBox4.Text),
                                      int.Parse(textBox5.Text),
                                      int.Parse(textBox6.Text),
                                      int.Parse(textBox7.Text)};

            

                label9.Text = string.Format("{0} Ft", kontener.fizetendo(tomb).ToString());
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
