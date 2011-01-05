<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.User>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
Register

    <% using (Html.BeginForm()) { %>
    	<div>
            <fieldset>
                <legend>Account Information</legend>
                
                <p>
					<label for="">username</label>:
                    <%= Html.TextBox("username") %>
                </p>
                <p>
					<label for="">password</label>:
                    <%= Html.TextBox("password") %>
                </p>
                <p>
					<label for="">confirm password</label>:
                    <%= Html.TextBox("confirmPassword") %>
                </p>  
                <p>
					<label for="">email</label>:
                    <%= Html.TextBox("email") %>
                </p>                     
                
                <p>
                    <input type="submit" value="Register" />
                </p>
            </fieldset>
        </div>
    <% } %>
    
</asp:Content>
