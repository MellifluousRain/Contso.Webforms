using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Utility;
using Contso.Service;

namespace ContsoWeb.Course
{
    public partial class EditCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDepartmentid.DataSource = Utility.GetAllDepartment();
                ddlDepartmentid.DataTextField = "DepartmentName";
                ddlDepartmentid.DataValueField = "ID";
                ddlDepartmentid.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var CourseID = Request.QueryString["ID"];

            Contso.Model.Courses obj = new Contso.Model.Courses();
            obj.id = Convert.ToInt32(CourseID);
            obj.Title = txtTitle.Text;
            obj.Credits = Convert.ToSingle(txtCredits.Text);
            obj.Departmentid = Convert.ToInt32(ddlDepartmentid.SelectedValue);
            obj.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
            obj.CreatedBy = txtCreatedBy.Text;
            obj.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
            obj.UpdatedBy = txtUpdatedBy.Text;
            CoursesService courseService = new CoursesService();
            courseService.Update(obj);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}