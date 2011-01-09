<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.Structure>" %>
<%@ Import Namespace="CMSWeb.Models" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
<%= Html.ActionLink("Edit Mode", "Edit", new { structureId=Model.StructureID }) %>
<h2>Browse Structure : <%= Model.StructureName %></h2>
	
		
		<h3><%= (ViewData["Document"] as Document).DocumentName %></h3>
		
		<div><%= (ViewData["Document"] as Document).DocumentData %></div>
	
</asp:Content>
