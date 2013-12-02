using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //myRepeater.DataSource = allEmployees;
                //myRepeater.DataBind();

                if (HttpContext.Current.Session["list"] == null)
                {
                    EmployeeService myE = new EmployeeService();
                    myE.createEmployees();
                    List<Employee> allEmployees = myE.getAll();
                    HttpContext.Current.Session["list"] = allEmployees;
                    myGridView.DataSource = HttpContext.Current.Session["list"];
                    myGridView.DataBind();
                }
                else
                {
                    myGridView.DataSource = HttpContext.Current.Session["list"];
                    myGridView.DataBind();
                }
            }
        }
    }
}