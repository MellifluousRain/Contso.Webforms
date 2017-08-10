using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;

namespace ContsoWeb.Course
{
    public partial class CourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CoursesService courseService = new CoursesService();
                RepeaterCourse.DataSource = courseService.GetAll();
                RepeaterCourse.DataBind();
            }
        }

        protected void RepeaterCourse_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var CourseID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditCourse.aspx?id=" + CourseID);
            }
            if (e.CommandName == "Delete")
            {
                CoursesService courseService = new CoursesService();
                courseService.DeleteById(CourseID);
                Response.Redirect("CourseList.aspx");
            }
            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailCourse.aspx?id=" + CourseID);
            }
        }
    }
}