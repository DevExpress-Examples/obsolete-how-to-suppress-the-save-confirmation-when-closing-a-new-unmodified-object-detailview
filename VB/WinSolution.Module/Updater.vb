Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim v As New Vendor(Session)
			v.OrganizationType = OrganizationType.International
			v.VendorType = VendorType.Organization
			v.Name="Vendor1"
			Dim p As New Product(Session)
			p.Name="Product1"
			p.Price = 100D
			p.Vendor = v
			p.Save()
			v.Save()
		End Sub
	End Class
End Namespace
