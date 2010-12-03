<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content><asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	<%= Html.Encode(ViewData["Message"]) %>
	<% if (User.Identity.IsAuthenticated) { %>
		Hello <%= User.Identity.Name %>
	<% } else { %>
		Not logged in
	<% } %>
</asp:Content>
