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

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            /*get the button that raised the event*/
            Button btn = (Button)sender;

            /*get the row that contains this button*/
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            /*get rowindex*/
            int rowindex = gvr.RowIndex;

            GridViewRow row = myGridView.Rows[rowindex];

            long idToDelete = Convert.ToInt64(row.Cells[0].Text);

            /*adaugat confirm box pentru stergere*/
            //this.ClientScript.RegisterStartupScript(typeof(Page), "Popup", "ConfirmApproval('" + str + "');", true); document.getElementById('btn_delete').click();
            //ClientScript.RegisterStartupScript(typeof(Page), "exampleScript", "if(confirm('Are you sure you want to delete this employee?')) { Response.Write(ANA) } ", true);
            /*var ans = confirm("Record already exist.Do you want to proceed?");
            if(ans==true)
            {
                Response.Write("DA");
            }
            else
            {
            }*/

            var myEmployees = (HttpContext.Current.Session["list"] as List<Employee>) ?? new List<Employee>();
            Employee toDelete = myEmployees.FirstOrDefault<Employee>(ee => ee.Id == idToDelete);

            myEmployees.Remove(toDelete);
            Response.Redirect("Employees.aspx");
        }
    }
}