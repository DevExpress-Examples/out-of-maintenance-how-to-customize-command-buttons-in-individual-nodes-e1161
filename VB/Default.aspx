<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="HideCommandButton._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v8.3, Version=8.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="EmployeeID" ParentFieldName="ReportsTo" OnHtmlCommandCellPrepared="ASPxTreeList1_HtmlCommandCellPrepared">
			<Columns>
				<dxwtl:TreeListCommandColumn VisibleIndex="0">
					<EditButton Visible="True">
					</EditButton>
				</dxwtl:TreeListCommandColumn>
				<dxwtl:TreeListTextColumn FieldName="LastName" VisibleIndex="1">
				</dxwtl:TreeListTextColumn>
				<dxwtl:TreeListTextColumn FieldName="FirstName" VisibleIndex="2">
				</dxwtl:TreeListTextColumn>
				<dxwtl:TreeListTextColumn FieldName="Title" VisibleIndex="3">
				</dxwtl:TreeListTextColumn>
			</Columns>
		</dxwtl:ASPxTreeList>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
			DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeID] = @EmployeeID" InsertCommand="INSERT INTO [Employees] ([LastName], [FirstName], [Title], [ReportsTo]) VALUES (@LastName, @FirstName, @Title, @ReportsTo)"
			SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Title], [ReportsTo] FROM [Employees]"
			UpdateCommand="UPDATE [Employees] SET [LastName] = @LastName, [FirstName] = @FirstName, [Title] = @Title, [ReportsTo] = @ReportsTo WHERE [EmployeeID] = @EmployeeID">
			<DeleteParameters>
				<asp:Parameter Name="EmployeeID" Type="Int32" />
			</DeleteParameters>
			<UpdateParameters>
				<asp:Parameter Name="LastName" Type="String" />
				<asp:Parameter Name="FirstName" Type="String" />
				<asp:Parameter Name="Title" Type="String" />
				<asp:Parameter Name="ReportsTo" Type="Int32" />
				<asp:Parameter Name="EmployeeID" Type="Int32" />
			</UpdateParameters>
			<InsertParameters>
				<asp:Parameter Name="LastName" Type="String" />
				<asp:Parameter Name="FirstName" Type="String" />
				<asp:Parameter Name="Title" Type="String" />
				<asp:Parameter Name="ReportsTo" Type="Int32" />
			</InsertParameters>
		</asp:SqlDataSource>
	</div>
	</form>
</body>
</html>
