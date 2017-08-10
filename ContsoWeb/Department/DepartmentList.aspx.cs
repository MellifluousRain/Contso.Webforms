using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;

namespace ContsoWeb.Department
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DepartmentService departmentService = new DepartmentService();
                RepeaterDepartment.DataSource = departmentService.GetAll();
                RepeaterDepartment.DataBind();
            }
        }

        protected void RepeaterDepartment_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var DepartmentID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditDepartment.aspx?id=" + DepartmentID);
            }
            if (e.CommandName == "Delete")
            {
                DepartmentService departmentService = new DepartmentService();
                departmentService.DeleteById(DepartmentID);
                Response.Redirect("DepartmentList.aspx");
            }
            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailDepartment.aspx?id=" + DepartmentID);
            }
        }
    }
}