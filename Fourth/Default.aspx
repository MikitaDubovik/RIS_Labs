<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Fourth._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center">
        <asp:Label ID="lbMessage" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnData" runat="server" ClientIDMode="AutoID" CssClass="btn-info" OnClick="btnData_Click" Text="Data" />

        <asp:Button ID="btnTime" runat="server" CssClass="btn-primary" OnClick="btnTime_Click" Text="Time" />
        <asp:Button ID="btnTimeAndData" runat="server" CssClass="btn-warning" OnClick="btnDataAndTime_Click" Text="Data And Time" />
    </div>
</asp:Content>
