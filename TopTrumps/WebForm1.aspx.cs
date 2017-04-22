using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TopTrumps
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
            


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = GridView1.SelectedRow.Cells[4].Text;
    
                Label1.Text = Convert.ToString(a);
            



        }
    }
}