<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PeopleList.aspx.cs" Inherits="ContsoWeb.People.PeopleList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        List Of People
    </h2>
    <hr />
    <a href="AddPerson.aspx">Add Person</a>
    <asp:Repeater ID="RepeaterPerson" runat="server" OnItemCommand="RepeaterPerson_ItemCommand">
        <HeaderTemplate>
            <table class="table table-striped">
                <tr class="info alert-info">
                    <td>ID</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Email</td>
                    <td>Phone</td>
                    <td>Age</td>
                    <td>Actions</td>
                </tr>
        </HeaderTemplate>

        <ItemTemplate>
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
                    <asp:Label ID="LblEmail" Text='<%# Eval("Email") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblPhone" Text='<%# Eval("Phone") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblAge" Text='<%# Eval("Age") %>' runat="server" />
                </td>
                <td>
                    <asp:Button Text="Edit" ID="btnEdit" runat="server" CssClass="btn btn-primary" CommandName="Edit" CommandArgument='<%# Eval("id") %>'/>
                    <asp:Button Text="Delete" ID="btnDelete" runat="server" CssClass="btn btn-danger" CommandName="Delete" CommandArgument='<%# Eval("id") %>'/>
                    <asp:Button Text="Details" ID="btnDetails" runat="server" CssClass="btn btn-success" CommandName="Details" CommandArgument='<%# Eval("id") %>'/>
                </td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
