Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace HideCommandButton
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				ASPxTreeList1.DataBind()
				ASPxTreeList1.ExpandAll()
			End If
		End Sub

		Protected Sub ASPxTreeList1_HtmlCommandCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListHtmlCommandCellEventArgs)
			' disable editing of top level nodes
			If e.Level = 1 Then
				e.Cell.Controls(0).Visible = False
			End If
		End Sub
	End Class
End Namespace
