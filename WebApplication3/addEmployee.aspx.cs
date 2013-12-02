using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class addEmployee : System.Web.UI.Page
    {
        /*List<Employee> allEmployees;
        EmployeeService myE;*/
        protected void Page_Load(object sender, EventArgs e)
        {
            drop_down.DataSource = Session["list"];
            drop_down.DataTextField = "Name";
            drop_down.DataValueField = "Id";
            drop_down.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            var myEmployee = (HttpContext.Current.Session["list"] as List<Employee>) ?? new List<Employee>();

            /*take data completed by user*/
            String name = txtbox_name.Text;
            String city = txtbox_city.Text;
            String dpt = txtbox_dpt.Text;
            String comp = txtbox_comp.Text;
            long id = myEmployee.Max(x => x.Id) + 1;
            String mgrString = drop_down.SelectedValue;
            //int mgrNumber = Integer.Parse(mgrString);
            int mgrNumber = Convert.ToInt32(mgrString);

            EmployeeService myE = new EmployeeService();
            List<Employee> allEmployees = myE.getAll();
            Employee mgr = allEmployees.FirstOrDefault<Employee>(p => p.Id == mgrNumber);

            Employee ee = new Employee(name, id, city, dpt, comp, mgr);

            //Employee newEmployee = new Employee(name, id, city, dpt, comp);

            
            myEmployee.Add(ee);

            

            //HttpContext.Current.Session["list"] = myEmployee;

            Response.Redirect("Employees.aspx");
        }
    }
}