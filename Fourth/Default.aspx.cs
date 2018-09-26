using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fourth
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnData_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "Data " + DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;
        }

        protected void btnTime_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "Time " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        protected void btnDataAndTime_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "Data and Time " + DateTime.Now;
        }
    }
}