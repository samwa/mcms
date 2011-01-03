<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.Structure>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
Browse Structure : <%= Model.StructureName %>
	
		<%= Html.ActionLink("Edit Mode", "Edit", new { structureId=Model.StructureID }) %>
	
</asp:Content>
