<%@ Page Title="Simple Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="WebAppClient.SamplePages.SimpleQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="jumbotron col-12">
            <h1>Simple Query</h1>
            <blockquote class="alert alert-info">
                This page will input a region number and the record matching the input value.
            </blockquote>
        </div>
    </div>

    <div class="row">
        <div class="col-6">
            <asp:Label ID="Label1" runat="server" Text="Enter a region id:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="RegionArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:Button ID="RegionSearch" runat="server" Text="Region ?" OnClick="RegionSearch_Click" />
        </div>
        <div class="col-6">
            <asp:Label ID="RegionId" runat="server" Text="Region:"></asp:Label><br />
            <asp:Label ID="RegionDescription" runat="server" Text="Description:"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="RegionDescription"></asp:Label>
<%--            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>--%>

        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-12 text-center">
            <asp:Label ID="MessageLable" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

<%--    <div class="row">
        <div class="col-12 text-center">
            <asp:Label Text="text" runat="server" />
            <input type="type" name="name" value="" />
        </div>
    </div>--%>
</asp:Content>
