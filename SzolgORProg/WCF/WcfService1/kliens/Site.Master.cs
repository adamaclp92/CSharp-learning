using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kliens.ServiceReference1;

namespace kliens
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();

            
            Label1.Text =  client.HelloWorld();
        }
    }
}