using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsORama
{
    public partial class UsePalindromeCheckRenderedControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.PlindromeCheckerRenderedControl1.Text = this.TextBox1.Text;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PlindromeCheckerRenderedControl1_PalindromeFound(object sender, EventArgs e)
        {
            Response.Write("The page detected a PalindromeFound event");
        }
    }
}