using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;

namespace ContsoWeb.Course
{
    public partial class DetailCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var CourseID = Request.QueryString["ID"];
                CoursesService courseService = new CoursesService();
                Contso.Model.Courses obj = courseService.GetById(Convert.ToInt32(CourseID));

                DepartmentService departmentService = new DepartmentService();

                LblId.Text =obj.id.ToString();
                LblTitle.Text = obj.Title;
                LblCredits.Text = obj.Credits.ToString();
                LblDepartment.Text = departmentService.GetById(obj.Departmentid).Name;
                LblCreatedDate.Text = obj.CreatedDate.ToString();
                LblCreatedBy.Text = obj.CreatedBy;
                LblUpdatedDate.Text = obj.UpdatedDate.ToString();
                LblUpdatedBy.Text = obj.UpdatedBy;
            }
        }
    }
}