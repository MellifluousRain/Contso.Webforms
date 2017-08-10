using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;

namespace ContsoWeb.Department
{
    public partial class DetailDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var DepartmentID = Request.QueryString["ID"];
                DepartmentService departmentService = new DepartmentService();
                Contso.Model.Department obj = departmentService.GetById(Convert.ToInt32(DepartmentID));

                PeopleService peopleService = new PeopleService();
                Contso.Model.People obj2 = peopleService.GetById(obj.Instructorid);

                LblId.Text = DepartmentID.ToString();
                LblName.Text = obj.Name;
                LblBudget.Text = obj.Budget.ToString();
                LblStartDate.Text = obj.StartDate.ToString();
                LblInstructor.Text = obj2.FirstName + " " +obj2.LastName;
                LblRowVersion.Text = obj.RowVersion;
                LblCreatedDate.Text = obj.CreatedDate.ToString();
                LblCreatedBy.Text = obj.CreatedBy;
                LblUpdatedDate.Text = obj.UpdatedDate.ToString();
                LblUpdatedBy.Text = obj.UpdatedBy;
            }
        }
    }
}