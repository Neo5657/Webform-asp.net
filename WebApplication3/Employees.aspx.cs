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
            EmployeeService myE = new EmployeeService();
            myE.createEmployees();
            List<Employee> allEmployees=  myE.getAll();
            myRepeater.DataSource = allEmployees;
            myRepeater.DataBind();
        }
    }
}