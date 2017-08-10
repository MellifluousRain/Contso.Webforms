<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="ContsoWeb.Course.AddCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtTitle">Title</label>
        <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtCredits">Credits</label>
        <asp:TextBox runat="server" ID="txtCredits" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="">Department</label>
        <asp:DropDownList runat="server" ID="ddlDepartmentid" CssClass="form-control">
        </asp:DropDownList>
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

    <asp:Button Text="SaveDepartment" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary" />
    <asp:Button Text="Cancel" runat="server" CausesValidation="false" ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" />
</asp:Content>
