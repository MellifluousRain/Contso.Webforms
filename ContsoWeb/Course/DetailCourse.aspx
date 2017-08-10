<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailCourse.aspx.cs" Inherits="ContsoWeb.Course.DetailCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Person Details
    </h4>
    <a href="PeopleList.aspx">Back to People List</a>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>ID</td>
            <td>Title</td>
            <td>Credits</td>
            <td>Department</td>
            <td>Created Date</td>
            <td>Created By</td>
            <td>Updated Date</td>
            <td>Updated By</td>
        </tr>
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
                <asp:Label ID="LblDepartment" Text='<%# Eval("Department") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblCreatedDate" Text='<%# Eval("CreatedDate") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblCreatedBy" Text='<%# Eval("CreatedBy") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblUpdatedDate" Text='<%# Eval("UpdatedDate") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblUpdatedBy" Text='<%# Eval("UpdatedBy") %>' runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
