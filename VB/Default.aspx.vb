Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web.ASPxClasses

Namespace HideCommandButton
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				ASPxTreeList1.DataBind()
				ASPxTreeList1.ExpandAll()
			End If
		End Sub

		Protected Sub ASPxTreeList1_CommandColumnButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCommandColumnButtonEventArgs)
			Dim node As TreeListNode =ASPxTreeList1.FindNodeByKeyValue(e.NodeKey.ToString())
			If node.Level = 1 Then
				e.Visible = DefaultBoolean.False
			End If
		End Sub
	End Class
End Namespace
