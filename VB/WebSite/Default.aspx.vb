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

Partial Public Class TreeList_Data_BindToClientSideXml_Default
	Inherits System.Web.UI.Page
	Private Const Key As String = "SomeUniqueString"

	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)
		Bind()
	End Sub

	Protected Sub ASPxTreeList1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs)
		Session(Key) = e.Argument
		Bind()
	End Sub

	Private Sub Bind()
		If Session(Key) IsNot Nothing Then
			Try
				XmlDataSource1.Data = Session(Key).ToString()
				ASPxTreeList1.DataSourceID = XmlDataSource1.ID
				ASPxTreeList1.DataBind()
			Catch
				Session(Key) = Nothing
				Throw
			End Try
		End If
	End Sub

End Class
