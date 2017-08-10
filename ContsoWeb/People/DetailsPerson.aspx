<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPerson.aspx.cs" Inherits="ContsoWeb.People.DetailsPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Person Details
    </h4>
    <a href="PeopleList.aspx">Back to People List</a>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>ID</td>
            <td>First Name</td>
            <td>Last Name</td>
            <td>Middle Name</td>
            <td>Age</td>
            <td>Email</td>
            <td>Phone</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblId" Text='<%# Eval("id") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblFirstName" Text='<%# Eval("FirstName") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblLastName" Text='<%# Eval("LastName") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblMiddleName" Text='<%# Eval("MiddleName") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblAge" Text='<%# Eval("Age") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblEmail" Text='<%# Eval("Email") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblPhone" Text='<%# Eval("Phone") %>' runat="server" />
            </td>
        </tr>
    </table>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>Address Line 1</td>
            <td>Address Line 2</td>
            <td>Unit Or Apartment Number</td>
            <td>City</td>
            <td>State</td>
            <td>Zipcode</td>
            <td>CreatedDate</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblAddressLine1" Text='<%# Eval("AddressLine1") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblAddressLine2" Text='<%# Eval("AddressLine2") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblUnitOrApartmentNumber" Text='<%# Eval("UnitOrApartmentNumber") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblCity" Text='<%# Eval("City") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblState" Text='<%# Eval("State") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblZipcode" Text='<%# Eval("Zipcode") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblCreatedDate" Text='<%# Eval("CreatedDate") %>' runat="server" />
            </td>
            
        </tr>
    </table>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>CreatedBy</td>
            <td>UpdatedDate</td>
            <td>UpdatedBy</td>
            <td>Salt</td>
            <td>IsLocked</td>
            <td>Last Locked Date Time</td>
            <td>Failed Attempts</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblCreatedBy" Text='<%# Eval("CreatedBy") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblUpdatedDate" Text='<%# Eval("UpdatedDate") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblUpdatedBy" Text='<%# Eval("UpdatedBy") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblSalt" Text='<%# Eval("Salt") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblIsLocked" Text='<%# Eval("IsLocked") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblLastLockedDateTime" Text='<%# Eval("LastLockedDateTime") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblFailedAttempts" Text='<%# Eval("FailedAttempts") %>' runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
