using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Utility;
using Contso.Model;
using Contso.Service;



namespace ContsoWeb.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlState.DataSource = Utility.GetAllStates();
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "Value";
                ddlState.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)   // if invalid, browser won't even go here, then why use this?
                                // because if user disables javascript, .aspx validation won't work, this is a backup.
            {
                Contso.Model.People obj = new Contso.Model.People();
                obj.FirstName = txtFirstName.Text;
                obj.LastName = txtLastName.Text;
                obj.MiddleName = txtMiddleName.Text;
                obj.Age = Convert.ToInt32(txtAge.Text);
                obj.Email = txtEmail.Text;
                obj.Phone = txtPhone.Text;
                obj.AddressLine1 = txtAddressLine1.Text;
                obj.AddressLine2 = txtAddressLine2.Text;
                obj.UnitOrApartmentNumber = txtUnitOrApartmentNumber.Text;
                obj.City = txtCity.Text;
                obj.State = ddlState.SelectedValue;
                obj.Zipcode = txtZipcode.Text;
                obj.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
                obj.CreatedBy = txtCreatedBy.Text;
                obj.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
                obj.UpdatedBy = txtUpdatedBy.Text;
                obj.Salt = txtSalt.Text;
                obj.IsLocked = txtIsLocked.Text;
                obj.LastLockedDateTime = Convert.ToDateTime(txtLastLockedDateTime.Text);
                obj.FailedAttempts = Convert.ToInt32(txtFailedAttempts.Text);
                PeopleService peopleService = new PeopleService();
                peopleService.Insert(obj);
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}