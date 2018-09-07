using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControLib
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PalindromeCheckerCompositeControl runat=server></{0}:PalindromeCheckerCompositeControl>")]
    public class PalindromeCheckerCompositeControl : CompositeControl
    {
        protected TextBox textboxPalindrome;
        protected Button buttonCheckForPalindreome;
        protected Label labelForTextBox;
        protected LiteralControl literalcontrolPalindromeStatus;
        public event EventHandler PalindromeFound;

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(Text);
        }
    }
}
