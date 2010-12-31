<%@ Page Language="C#" MasterPageFile="~/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<CMSWeb.Models.Structure>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create Structure</h2>
    
    
    <% using (Html.BeginForm()) {%>

    <fieldset>
        <legend>Create Structure</legend>			
		<p>
			<label for="">Structure name</label>: <input type="text" name="StructureName" value="" />
		</p>
        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to Structures", "List") %>
    </div>

</asp:Content>
