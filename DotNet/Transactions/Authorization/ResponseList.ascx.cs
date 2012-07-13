using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayTrace.Integration.API;
namespace Authorization
{
    public partial class ResponseList : System.Web.UI.UserControl
    {
        private string _title = "Response Values";
        public string Title 
        { 
            get { return _title; } 
            set { _title = value; } 
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void BindData(Response response)
        {
            this.Visible = true;
            lblTitle.Text = Title;
            lblShowErrorMessage.Visible = false;
            ResponseGrid.Visible = false;

            if (response.HasError)
            {
                lblShowErrorMessage.Visible = true;
                lblShowErrorMessage.Text = response.Raw;
                return;
            }


            ResponseGrid.Visible = true;
            ResponseGrid.DataSource = response.ResponseValues;
            ResponseGrid.DataBind();
        }
    }
}