﻿<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	<%= ViewData["Message"] %>
	<%= Html.ActionLink("Back to configuration", "Index") %>
</asp:Content>
