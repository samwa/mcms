<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IList<CMSWeb.Models.Document>>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

Document List
<ul>
<% foreach (var document in Model) { %>
	<li>
		<%= Html.ActionLink(document.DocumentName, "View", new { id=document.DocumentID }) %>
        <%= Html.ActionLink("X", "Reject", new { id=document.DocumentID })%></li>
<% } %>
</ul>
</asp:Content>
