<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	
    
    <% using (Html.BeginForm("Configure", "Configuration")) { %>
    
    	<%= Html.SubmitButton("Button", "Reset Documents") %>
    	<%= Html.SubmitButton("Button", "Reset Structure") %>
    	<%= Html.SubmitButton("Button", "Reset Users") %>
	
    <% } %>
</asp:Content>
