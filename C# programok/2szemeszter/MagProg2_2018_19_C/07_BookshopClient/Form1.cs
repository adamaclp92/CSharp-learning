using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_BookshopDLL;

namespace _07_BookshopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Address addr = new Address("3324", "Balassagyarmat", "Rákóczi út...");
            User Ede = new User("Ede", "Troll",
                "troll.ede@uni-eszterhazy.hu", "P4SSW0RD");
            Ede.SendEmail("Üzenet trágya", "Hellóbelló!");

            string msg = "<html><head></head><body>" +
                "<h1>{Firstname} {Lastname}</h1>" +
                "Azt üzenem tenéked, hogy...." +
                "</body></html>";
            Ede.SendHTMLEmail("Hírlevél",
                msg
                .Replace("{Firstname}", Ede.FirstName)
                .Replace("{Lastname}", Ede.LastName));
        }
    }
}
