using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace CustomControLib
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PlindromeCheckerRenderedControl runat=server></{0}:PlindromeCheckerRenderedControl>")]
    public class PlindromeCheckerRenderedControl : WebControl
    {
        public event EventHandler PalindromeFound;
        ArrayList alpaindrome = new ArrayList();

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

                string text = value;
                this.alpaindrome = (ArrayList)this.ViewState["palindrome"];
                if (this.alpaindrome == null)
                {
                    this.alpaindrome = new ArrayList();
                }
                if (this.CheckForPalindrome())
                {
                    if (this.PalindromeFound != null)
                    {
                        PalindromeFound(this,EventArgs.Empty);
                    }

                    alpaindrome.Add(text);
                }
                ViewState.Add("palindrome", alpaindrome);
                
            }
        }
#if false
        protected override void RenderContents(HtmlTextWriter output)
        {
            
            if (this.CheckForPalindrome())
            {
                output.Write("This is a painrome:<BR/>");
                output.Write("<FONT size=5 color=blue>");
                output.Write("<B>");
                output.Write(this.Text);
                output.Write("<B>");
                output.Write("</FRON>");
            }
            else
            {
                output.Write("This is NOT a painrome:<BR/>");
                output.Write("<FONT size=5 color=red>");
                output.Write("<B>");
                output.Write(this.Text);
                output.Write("<B>");
                output.Write("</FRON>");
            }
        }
#endif

        protected override void RenderContents(HtmlTextWriter output)
        {

            if (this.CheckForPalindrome())
            {
                output.Write("This is a painrome:<br/>");
                output.RenderBeginTag(HtmlTextWriterTag.Font);
                output.AddStyleAttribute(HtmlTextWriterStyle.Color,"blue");
                output.RenderBeginTag(HtmlTextWriterTag.B);
                output.Write(Text);
                output.RenderEndTag();
                output.RenderEndTag();
            }
            else
            {
                output.Write("This is a painrome:<br/>");
                output.RenderBeginTag(HtmlTextWriterTag.Font);
                output.AddStyleAttribute(HtmlTextWriterStyle.Color, "red");
                output.RenderBeginTag(HtmlTextWriterTag.B);
                output.Write(Text);
                output.RenderEndTag();
                output.RenderEndTag();
            }

            output.Write("<br>");
            RenderPalindromesinTable(output);
        }
        protected bool CheckForPalindrome()
        {
            if (this.Text != null)
            {
                String strControlText = this.Text;
                String strTextToUpper = null;
                strTextToUpper = Text.ToUpper();
                strControlText = this.StripNonAlphanumerice(strTextToUpper);

                char[] rgcReverse = strControlText.ToCharArray();
                Array.Reverse(rgcReverse);

                String strReverse = new string(rgcReverse);
                if (strControlText == strReverse)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else 
            {
                return false;
            }   
        }

        
        protected string StripNonAlphanumerice(string str)
        {
            string strStripped = (String)str.Clone();
            if (str != null)
            { 
                char[] rgc = strStripped.ToCharArray();
                int i = 0;
                foreach (char c in rgc)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        i++;
                    }
                    else
                    {
                        strStripped = strStripped.Remove(i, 1);
                    }
                }
            }

            return strStripped;
        }

        protected void RenderPalindromesinTable(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Width,"50%");
            output.AddAttribute(HtmlTextWriterAttribute.Border,"1");
            output.RenderBeginTag(HtmlTextWriterTag.Table);

            foreach (string s in this.alpaindrome)
            {
                output.RenderBeginTag(HtmlTextWriterTag.Tr);
                output.AddAttribute(HtmlTextWriterAttribute.Align,"left");
                output.AddStyleAttribute(HtmlTextWriterStyle.FontSize,"medium");
                output.AddStyleAttribute(HtmlTextWriterStyle.Color,"blue");
                output.RenderBeginTag(HtmlTextWriterTag.Td);
                output.Write(s);
                output.RenderEndTag();
                output.RenderEndTag();
            }
            output.RenderEndTag();
        
        }
    }
}
