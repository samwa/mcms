<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.Structure>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Structure</h2>
    
    
    <% using (Html.BeginForm()) {%>
		<%= Html.Hidden("StructureID", Model.StructureID) %>
	    <fieldset>
	        <legend>Edit Structure</legend>
			<p>
				<label for="">Structure name</label>:
				<%= Html.TextBox("StructureName", Model.StructureName) %>
			</p>
	        <p>
	            <input type="submit" value="Save" />
	        </p>
	    </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to Structures", "Index") %>
    </div>
</asp:Content>
