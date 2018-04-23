Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.SystemModule

Namespace WinSolution.Module.Win
	Public Class SuppressConfirmationForNewObjectsDetailViewController
		Inherits ViewController(Of DetailView)
		Private worker As WinDetailViewController
		Protected Overrides Overloads Sub OnActivated()
			MyBase.OnActivated()
			AddHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
			If ObjectSpace.IsNewObject(View.CurrentObject) Then
				worker = Frame.GetController(Of WinDetailViewController)()
				worker.SuppressConfirmation = True
			End If
		End Sub
		Protected Overrides Overloads Sub OnDeactivating()
			RemoveHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
			MyBase.OnDeactivated()
		End Sub
		Private Sub ObjectSpace_ObjectChanged(ByVal sender As Object, ByVal e As ObjectChangedEventArgs)
			If worker IsNot Nothing Then
				worker.SuppressConfirmation = False
			End If
		End Sub
	End Class
End Namespace