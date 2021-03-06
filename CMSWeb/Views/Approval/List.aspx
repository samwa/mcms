﻿<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IList<CMSWeb.Models.Document>>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

Document List
<ul>
<% foreach (var document in Model) { %>
	<li>
		<%= Html.ActionLink(document.DocumentName, "View", new { documentId=document.DocumentID.Value }) %>
        <%= Html.ActionLink("X", "Reject", new { documentId=document.DocumentID.Value })%>
    </li>
<% } %>
</ul>
</asp:Content>
