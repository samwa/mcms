<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.Document>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
		
		<h3><%= Model.DocumentName %></h3>
		
		<div><%= Model.DocumentData %></div>		
		
		<%= Html.ActionLink("Approve", "Approve", new { documentId=Model.DocumentID.Value }) %>
        <%= Html.ActionLink("Reject", "Reject", new { documentId=Model.DocumentID.Value })%>
</asp:Content>
