<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	You are not logged in
	<form action="/Account/DoLogin" method="post">
		Username: <input type="text" name="username" />
		Password: <input type="password" name="password" />
		<input type="submit" value="Login" />
	</form>
</asp:Content>
