using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contso.Service;
using Contso.Model;

namespace ContsoWeb.People
{
    public partial class DetailsPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var PersonId = Request.QueryString["ID"];
                PeopleService peopleService = new PeopleService();
                Contso.Model.People people = peopleService.GetById(Convert.ToInt32(PersonId));
                LblId.Text = people.id.ToString();
                LblLastName.Text = people.LastName;
                LblFirstName.Text = people.FirstName;
                LblMiddleName.Text = people.MiddleName;
                LblAge.Text = people.Age.ToString();
                LblEmail.Text = people.Email;
                LblPhone.Text = people.Phone;
                LblAddressLine1.Text = people.AddressLine1;
                LblAddressLine2.Text = people.AddressLine2;
                LblUnitOrApartmentNumber.Text = people.UnitOrApartmentNumber;
                LblCity.Text = people.City;
                LblState.Text = people.State;
                LblZipcode.Text = people.Zipcode;
                LblCreatedDate.Text = people.CreatedDate.ToString();
                LblCreatedBy.Text = people.CreatedBy;
                LblUpdatedDate.Text = people.UpdatedDate.ToString();
                LblUpdatedBy.Text = people.UpdatedBy;
                LblSalt.Text = people.Salt;
                LblIsLocked.Text = people.IsLocked;
                LblLastLockedDateTime.Text = people.LastLockedDateTime.ToString();
                LblFailedAttempts.Text = people.FailedAttempts.ToString();
            }
        }
    }
}