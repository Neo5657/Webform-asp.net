using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //Page.Title nu se retine in ViewState
        public string Title
        {
            get { return ViewState["titlu"] == null ? "" : ViewState["titlu"].ToString(); }
            set { ViewState["titlu"] = value; } 
        }

        public String Greetings
        {
            get { return ViewState["message"] == null ? "" : ViewState["message"].ToString(); }
            set { ViewState["message"] = value; }
        }

        protected void Page_Preinit(object sender, EventArgs e)
        {
            label_concatenation.Text += "Sunt in Page_Preinit ";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            label_concatenation.Text += "Sunt in Page_Init ";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                Button newButton = new Button();
                newButton.Text = "Click me";
                newButton.ID = "btn_click_me";
                myPanel.Controls.Add(newButton);
                newButton.Click += changeLabel;
            //}
            
            /*merge, dar nu folosim varianta asta*/
           //Greetings += "Sunt in Page_Load ";
            label_concatenation.Text += "Sunt in Page_Load ";

            /*apare doar pentru prima data cu if (!IsPostBack)*/
            if (!IsPostBack)
            {
                label_concatenation.Text += "Am aparut fara PostBack!!! ";
            }

        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Title))
            {
                Page.Title = Title;
            }
            label_concatenation.Text += "Sunt in Page_Prerender\n";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            label_concatenation.Text += "Sunt in Page_Unload ";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            label_concatenation.Text += "Sunt in Page_Render ";
        }

        protected void changeLabel(object sender, EventArgs e)
        {
            label_cartoon.Text = "Click me too";
            //throw new NotImplementedException();
        }


        /*gets the text from the textbox and writes it in the label*/
        public void tryIt(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            String cartoon = Request.Form["txtbox_cartoon"];

            if (!string.IsNullOrEmpty(cartoon))
            {
                //Response.Write("<br/>");
                //Response.Write(cartoon);
                label_cartoon.Text = cartoon;
            }
        }

        public void changeTitle(Object sender, EventArgs e)
        {
            Title = "Ceva";
        }

        public void hidePanel(object sender, EventArgs e)
        {
            myPanel.Visible = !myPanel.Visible;
            if (check.Text.Equals("Click to hide panel"))
                check.Text = "Unclick to show panel";
            else
                check.Text = "Click to hide panel";
        }

        public void removeClickMe(object sender, EventArgs e)
        {
            
            myPanel.Controls.Remove(Page.FindControl("btn_click_me"));
        }

        public void writeDropDown(object sender, EventArgs e)
        {
            String dropDownText = drop_down.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(dropDownText))
            {
                label_cartoon.Text = dropDownText;
            }
        }

        public void concatenateStrings(object sender, EventArgs e)
        {
            label_concatenation.Text += "Am dat click pe buton ";
        }
    }

}