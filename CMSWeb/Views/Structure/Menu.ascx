<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<CMSWeb.Models.Structure>>" %>

<ul>
    <% foreach (var structure in Model) { %>
		<%= Html.MenuItem(structure.StructureName, "Index", "Browse", new { StructureID = structure.StructureID }) %>
    <% } %>
</ul>