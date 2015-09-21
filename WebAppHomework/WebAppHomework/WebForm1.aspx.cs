using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebAppHomework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // jquery Error when trying to add any validators
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            using (StreamWriter add = new StreamWriter("D:\\SoftdnHM\\Soft-Intellect-.NET-Homework\\WebAppHomework\\WebAppHomework\\bin\\regfrom.txt", true))
            {
                add.WriteLine("Username is: " + textbox1.Text);
                add.WriteLine("Password is: " + textbox2.Text);
                add.WriteLine("Age is: " + textbox4.Text);
                add.WriteLine("E-mail is: " + textbox5.Text);
                add.WriteLine();
            }
        }
    }
}