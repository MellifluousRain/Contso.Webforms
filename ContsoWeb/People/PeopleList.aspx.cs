using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;

namespace ContsoWeb.People
{
    public partial class PeopleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PeopleService peopleService = new PeopleService();
                RepeaterPerson.DataSource = peopleService.GetAll();
                RepeaterPerson.DataBind();
            }
        }

        protected void RepeaterPerson_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var PersonId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditPerson.aspx?id=" + PersonId);
            }
            if (e.CommandName == "Delete")
            {
                PeopleService peopleService = new PeopleService();
                peopleService.DeleteById(PersonId);
                Response.Redirect("PeopleList.aspx");
            }
            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailsPerson.aspx?id=" + PersonId);
            }
        }
    }
}