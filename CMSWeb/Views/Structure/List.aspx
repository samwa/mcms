<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IList<CMSWeb.Models.Structure>>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="StructureListContent" ContentPlaceHolderID="MainContent" runat="server">
List
<ul>
<% foreach (var structure in Model) { %>
	<li><%= Html.Encode(structure.StructureName) %></li>
<% } %>
</ul>
</asp:Content>
