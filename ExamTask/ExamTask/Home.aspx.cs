using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace ExamTask
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                country Country = new country();
                Country.Countryy = txtB1.Text;
                Country.Capital = txtB2.Text;
                Country.Population = double.Parse(txtB3.Text);

                using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                {
                    writer.WriteLine(Country);
                }
                label.Visible = true;
                label.Text = "You have successfully enter your data!!!";
            }
            catch (Exception)
            {
                label.Visible = true;
                label.Text = "Please enter data!";
            }
        }
    }
}