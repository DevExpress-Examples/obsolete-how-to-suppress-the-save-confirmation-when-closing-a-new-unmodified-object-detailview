using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    [DefaultClassOptions]
    [ImageName("BO_Product")]
    public class Product : BaseObject {
        public Product(Session session) : base(session) { }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        private decimal _Price;
        public decimal Price {
            get { return _Price; }
            set { SetPropertyValue("Price", ref _Price, value); }
        }
        private string _Description;
        public string Description {
            get { return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }
        private Vendor _Vendor;
        [Association("Vendor-Products")]
        public Vendor Vendor {
            get { return _Vendor; }
            set { SetPropertyValue("Vendor", ref _Vendor, value); }
        }
    }
    [DefaultClassOptions]
    [ImageName("BO_Organization")]
    public class Vendor : BaseObject {
        public Vendor(Session session) : base(session) { }
        VendorType _VendorType;
        bool _ActivateOrganizationType;
        OrganizationType _OrganizationType;
        [ImmediatePostData()]
        public VendorType VendorType {
            get { return _VendorType; }
            set { SetPropertyValue("VendorType", ref _VendorType, value); }
        }
        [ImmediatePostData()]
        public bool ActivateOrganizationType {
            get { return _ActivateOrganizationType; }
            set { SetPropertyValue("ActivateOrganizationType", ref _ActivateOrganizationType, value); }
        }
        public OrganizationType OrganizationType {
            get { return _OrganizationType; }
            set { SetPropertyValue("OrganizationType", ref _OrganizationType, value); }
        }
        [Association("Vendor-Products")]
        public XPCollection<Product> Products {
            get { return GetCollection<Product>("Products"); }
        }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
    }
    public enum VendorType {
        Person = 0,
        Organization = 1
    }
    public enum OrganizationType {
        National = 0,
        International = 1
    }
}