<%@ Page Title="Contoso University - Departments" Language="C#" MasterPageFile="~/monday.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="comp2007_lesson5_mon.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Departments</h1>
    <asp:GridView ID="grdDepartments" runat="server" CssClass="table table-striped"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Department Name" />
            <asp:BoundField DataField="Budget" HeaderText="Budget" DataFormatString="{0:c}" />
        </Columns>
    </asp:GridView>
</asp:Content>
