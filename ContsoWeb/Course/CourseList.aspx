<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="ContsoWeb.Course.CourseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        List Of Course
    </h2>
    <hr />
    <a href="AddCourse.aspx">Add Course</a>
    <asp:Repeater ID="RepeaterCourse" runat="server" OnItemCommand="RepeaterCourse_ItemCommand">
        <HeaderTemplate>
            <table class="table table-striped">
                <tr class="info alert-info">
                    <td>ID</td>
                    <td>Title</td>
                    <td>Credits</td>
                </tr>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="LblId" Text='<%# Eval("id") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblTitle" Text='<%# Eval("Title") %>' runat="server" />
                </td>
                <td>
                    <asp:Label ID="LblCredits" Text='<%# Eval("Credits") %>' runat="server" />
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
