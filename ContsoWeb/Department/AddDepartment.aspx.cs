using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Utility;
using Contso.Model;
using Contso.Service;

namespace ContsoWeb.Department
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlInstructorid.DataSource = Utility.GetAllPeople();
                ddlInstructorid.DataTextField = "PeopleName";
                ddlInstructorid.DataValueField = "ID";
                ddlInstructorid.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contso.Model.Department obj = new Contso.Model.Department();
            obj.Name = txtName.Text;
            obj.Budget =Convert.ToSingle( txtBudget.Text);
            obj.StartDate = Convert.ToDateTime(txtStartDate.Text);
            obj.Instructorid =Convert.ToInt32( ddlInstructorid.SelectedValue);
            obj.RowVersion = txtRowVersion.Text;
            obj.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
            obj.CreatedBy = txtCreatedBy.Text;
            obj.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
            obj.UpdatedBy = txtUpdatedBy.Text;
            DepartmentService departmentService = new DepartmentService();
            departmentService.Insert(obj);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}