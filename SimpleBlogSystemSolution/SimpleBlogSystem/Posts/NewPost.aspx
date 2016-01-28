<%@ Page Language="C#" Title="Add New Post" AutoEventWireup="true" CodeBehind="NewPost.aspx.cs" MasterPageFile="~/Admin/AdminPanel.Master" Inherits="SimpleBlogSystem.Posts.NewPost" %>

<asp:Content ContentPlaceHolderID="AdminContent" runat="server">
	<div class="row">
		<h2><%: Title %></h2>
	</div>
	<div class="row well">
		<div class="col-md-10">
			<asp:Label AssociatedControlID="PostTitle" runat="server" Text="Post title:"></asp:Label>
			<asp:TextBox ID="PostTitle" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Label AssociatedControlID="PostContent" runat="server" Text="Post content:"></asp:Label>
			<asp:TextBox ID="PostContent" runat="server" TextMode="multiline" Columns="50" Rows="50" CssClass="form-control"></asp:TextBox>
		</div>
		<div class="col-md-2">
			<div class="row">
				<asp:Button Text="Publish" class="btn btn-lg btn-primary" runat="server" OnClick="On_Publish"/>
			</div>
			<br />
			<div class="row">
				<asp:Label runat="server" AssociatedControlID="PostDateSelector" Text="Publish date:"></asp:Label>
				<asp:Calendar runat="server" ID="PostDateSelector" SelectedDate="<%# DateTime.Today %>"></asp:Calendar>
			</div>
			<br />
			<div class="row">
				<asp:Label AssociatedControlID="CategorySelect" Text="Categories:" runat="server"></asp:Label>
				<asp:CheckBoxList runat="server" ID="CategorySelect" CssClass="checkbox"></asp:CheckBoxList>
			</div>
			<div class="row">
				<asp:Label runat="server" AssociatedControlID="TagsList" Text="Tags:"></asp:Label>
				<asp:TextBox runat="server" ID="TagsList" CssClass="form-control"></asp:TextBox>
			</div>
		</div>
	</div>
	<div class="row">

	</div>
</asp:Content>
