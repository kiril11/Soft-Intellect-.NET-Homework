using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

namespace ExamTask
{
    public partial class SearchForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] spliter = line.Split('|');

                    if (spliter[0] == textBox.Text)
                    {
                        label.Text = spliter[0];
                    }


                }
            }
        }
    }
}