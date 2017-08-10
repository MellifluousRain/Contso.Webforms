<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContsoWeb.People.AddPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Add A Person</h4>
    <hr />
    <div class="form-group">
        <label for="txtFirstName">First Name</label>
        <asp:TextBox runat="server" MaxLength="50" ID="txtFirstName" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="ReqFirstName" ErrorMessage="First Name Should Not Be Empty." ControlToValidate="txtFirstName" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtLastName">Last Name</label>
        <asp:TextBox runat="server" MaxLength="50" ID="txtLastName" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="ReqLastName" ErrorMessage="Last Name Should Not Be Empty." ControlToValidate="txtLastName" runat="server" />
    </div>
    <div class="form-group">
        <label for="txtMiddleName">Middle Name</label>
        <asp:TextBox runat="server" ID="txtMiddleName" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtAge">Age</label>
        <asp:TextBox runat="server" ID="txtAge" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtEmail">Email</label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="ReqEmail" ErrorMessage="Email Should Not Be Empty." ControlToValidate="txtEmail" runat="server" />
        <asp:RegularExpressionValidator CssClass="text-danger" ID="RegEmail" ErrorMessage="Email Should Be In Valid Format." ControlToValidate="txtEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
    </div>
    <div class="form-group">
        <label for="txtPhone">Phone</label>
        <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtAddressLine1">Address Line 1</label>
        <asp:TextBox runat="server" ID="txtAddressLine1" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtAddressLine2">Address Line 2</label>
        <asp:TextBox runat="server" ID="txtAddressLine2" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtUnitOrApartmentNumber">Unit Or Apartment Number</label>
        <asp:TextBox runat="server" ID="txtUnitOrApartmentNumber" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtCity">City</label>
        <asp:TextBox runat="server" ID="txtCity" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="">State</label>
        <asp:DropDownList runat="server" ID="ddlState" CssClass="form-control">

        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="txtZipcode">Zipcode</label>
        <asp:TextBox runat="server" ID="txtZipcode" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtCreatedDate">CreatedDate</label>
        <asp:TextBox runat="server" ID="txtCreatedDate" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtCreatedBy">CreatedBy</label>
        <asp:TextBox runat="server" ID="txtCreatedBy" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtUpdatedDate">UpdatedDate</label>
        <asp:TextBox runat="server" ID="txtUpdatedDate" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtUpdatedBy">UpdatedBy</label>
        <asp:TextBox runat="server" ID="txtUpdatedBy" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtSalt">Salt</label>
        <asp:TextBox runat="server" ID="txtSalt" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtIsLocked">IsLocked</label>
        <asp:TextBox runat="server" ID="txtIsLocked" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtLastLockedDateTime">LastLockedDateTime</label>
        <asp:TextBox runat="server" ID="txtLastLockedDateTime" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtFailedAttempts">FailedAttempts</label>
        <asp:TextBox runat="server" ID="txtFailedAttempts" CssClass="form-control" />
    </div>
    
    <asp:Button Text="SavePerson" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary" />
    <asp:Button Text="Cancel" runat="server" CausesValidation="false" ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" />
</asp:Content>
