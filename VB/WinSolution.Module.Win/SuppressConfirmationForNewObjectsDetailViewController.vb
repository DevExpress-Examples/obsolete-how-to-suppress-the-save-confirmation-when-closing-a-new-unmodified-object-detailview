Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.SystemModule
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

Namespace WinSolution.Module.Win
    Public Class SuppressConfirmationForNewObjectsDetailViewController
        Inherits ViewController(Of DetailView)

        Private worker As WinModificationsController
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
            If ObjectSpace.IsNewObject(View.CurrentObject) Then
                worker = Frame.GetController(Of WinModificationsController)()
                If worker IsNot Nothing Then
                    worker.ModificationsHandlingMode = DevExpress.ExpressApp.SystemModule.ModificationsHandlingMode.AutoRollback
                End If
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
            worker = Nothing
            MyBase.OnDeactivated()
        End Sub
        Private Sub ObjectSpace_ObjectChanged(ByVal sender As Object, ByVal e As ObjectChangedEventArgs)
            If worker IsNot Nothing Then
                worker.ModificationsHandlingMode = DevExpress.ExpressApp.SystemModule.ModificationsHandlingMode.Confirmation
            End If
        End Sub
    End Class
    <DefaultClassOptions> _
    Public Class DemoObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _Name As String
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", _Name, value)
            End Set
        End Property
    End Class
End Namespace