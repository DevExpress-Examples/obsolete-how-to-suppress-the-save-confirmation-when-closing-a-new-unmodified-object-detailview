using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Vendor v = new Vendor(Session);
            v.OrganizationType = OrganizationType.International;
            v.VendorType = VendorType.Organization;
            v.Name="Vendor1";
            Product p = new Product(Session);
            p.Name="Product1";
            p.Price = 100m;
            p.Vendor = v;
            p.Save();
            v.Save();
        }
    }
}
