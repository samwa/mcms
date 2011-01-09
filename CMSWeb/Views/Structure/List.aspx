<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IList<CMSWeb.Models.Structure>>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="StructureListContent" ContentPlaceHolderID="MainContent" runat="server">

<%= Html.MenuItem("Add", "Create", "Structure") %>		

<h2>List Structure</h2>
<ul>
<% foreach (var structure in Model) { %>
	<li>
		<%= Html.ActionLink(structure.StructureName, "Edit", new { id=structure.StructureID }) %>
        <%= Html.ActionLink("X", "Delete", new { id=structure.StructureID })%>
    </li>
<% } %>
</ul>
</asp:Content>
