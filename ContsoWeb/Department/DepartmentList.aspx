<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentList.aspx.cs" Inherits="ContsoWeb.Department.DepartmentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>List Of Department
    </h2>
    <hr />
    <a href="AddDepartment.aspx">Add Department</a>
    <asp:Repeater ID="RepeaterDepartment" runat="server" OnItemCommand="RepeaterDepartment_ItemCommand">
        <HeaderTemplate>
            <table class="table table-striped">
                <tr class="info alert-info">
                    <td>ID</td>
                    <td>Name</td>
                    <td>Budget</td>
                </tr>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="LblId" Text='<%# Eval("id") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblName" Text='<%# Eval("Name") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblBudget" Text='<%# Eval("Budget") %>' runat="server" />
                </td>
                <td>
                    <asp:Button Text="Edit" ID="btnEdit" runat="server" CssClass="btn btn-primary" CommandName="Edit" CommandArgument='<%# Eval("id") %>' />
                    <asp:Button Text="Delete" ID="btnDelete" runat="server" CssClass="btn btn-danger" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                    <asp:Button Text="Details" ID="btnDetails" runat="server" CssClass="btn btn-success" CommandName="Details" CommandArgument='<%# Eval("id") %>' />
                </td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
