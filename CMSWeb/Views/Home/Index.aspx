<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content><asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	<%= Html.Encode(ViewData["Message"]) %>
	
	
	<p>
		Page Rendered: <%= DateTime.Now.ToLongTimeString() %>
	</p>
	<span id="status">No Status</span>
	<br />
	<%= Ajax.ActionLink("Update Status", "GetStatus", new AjaxOptions { UpdateTargetId="status" }) %>
	<br /><br />
	<% using (Ajax.BeginForm("UpdateForm", new AjaxOptions {  UpdateTargetId= "textEntered" })) { %>
		<%= Html.TextBox("textBox1", "Enter text") %>
		<input type="submit" value="Submit" /><br/>
		<span id="textEntered">Nothing Entered</span>
	<% } %>
</asp:Content>
