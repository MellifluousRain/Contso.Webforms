<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailDepartment.aspx.cs" Inherits="ContsoWeb.Department.DetailDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Department Details
    </h4>
    <a href="DepartmentList.aspx">Back to Department List</a>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>ID</td>
            <td>Name</td>
            <td>Budget</td>
            <td>Start Date</td>
            <td>Instructor</td>
        </tr>
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
                <asp:Label ID="LblStartDate" Text='<%# Eval("StartDate") %>' runat="server" />
            </td>
            <td>
                <asp:Label ID="LblInstructor" Text='<%# Eval("Instructor") %>' runat="server" />
            </td>
        </tr>
    </table>
    <table class="table table-bordered">
        <tr class="info alert-info">
            <td>Row Version</td>
            <td>Created Date</td>
            <td>Created By</td>
            <td>Updated Date</td>
            <td>Updated By</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblRowVersion" Text='<%# Eval("RowVersion") %>' runat="server" />
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
