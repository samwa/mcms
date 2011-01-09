<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IList<CMSWeb.Models.User>>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

<h2>List Users</h2>
<ul>
<% foreach (var user in Model) { %>
	<li>
		<%= user.UserLogin %>
        <%= Html.ActionLink("make admin", "MakeAdmin", new { userName=user.UserLogin })%>
        <%= Html.ActionLink("X", "Delete", new { userName=user.UserLogin })%>
    </li>
<% } %>
</ul>
</asp:Content>
