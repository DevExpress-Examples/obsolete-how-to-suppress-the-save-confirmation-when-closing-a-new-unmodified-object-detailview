Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	<DefaultClassOptions, ImageName("BO_Product")> _
	Public Class Product
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
		Private _Price As Decimal
		Public Property Price() As Decimal
			Get
				Return _Price
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue("Price", _Price, value)
			End Set
		End Property
		Private _Description As String
		Public Property Description() As String
			Get
				Return _Description
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Description", _Description, value)
			End Set
		End Property
		Private _Vendor As Vendor
		<Association("Vendor-Products")> _
		Public Property Vendor() As Vendor
			Get
				Return _Vendor
			End Get
			Set(ByVal value As Vendor)
				SetPropertyValue("Vendor", _Vendor, value)
			End Set
		End Property
	End Class
	<DefaultClassOptions, ImageName("BO_Organization")> _
	Public Class Vendor
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _VendorType As VendorType
		Private _ActivateOrganizationType As Boolean
		Private _OrganizationType As OrganizationType
		<ImmediatePostData()> _
		Public Property VendorType() As VendorType
			Get
				Return _VendorType
			End Get
			Set(ByVal value As VendorType)
				SetPropertyValue("VendorType", _VendorType, value)
			End Set
		End Property
		<ImmediatePostData()> _
		Public Property ActivateOrganizationType() As Boolean
			Get
				Return _ActivateOrganizationType
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue("ActivateOrganizationType", _ActivateOrganizationType, value)
			End Set
		End Property
		Public Property OrganizationType() As OrganizationType
			Get
				Return _OrganizationType
			End Get
			Set(ByVal value As OrganizationType)
				SetPropertyValue("OrganizationType", _OrganizationType, value)
			End Set
		End Property
		<Association("Vendor-Products")> _
		Public ReadOnly Property Products() As XPCollection(Of Product)
			Get
				Return GetCollection(Of Product)("Products")
			End Get
		End Property
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
	Public Enum VendorType
		Person = 0
		Organization = 1
	End Enum
	Public Enum OrganizationType
		National = 0
		International = 1
	End Enum
End Namespace