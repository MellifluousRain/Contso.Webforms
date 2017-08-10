<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="ContsoWeb.Department.AddDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtName">Name</label>
        <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtBudget">Budget</label>
        <asp:TextBox runat="server" ID="txtBudget" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="txtStartDate">StartDate</label>
        <asp:TextBox runat="server" ID="txtStartDate" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="">Instructor</label>
        <asp:DropDownList runat="server" ID="ddlInstructorid" CssClass="form-control">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="txtRowVersion">RowVersion</label>
        <asp:TextBox runat="server" ID="txtRowVersion" CssClass="form-control" />
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
