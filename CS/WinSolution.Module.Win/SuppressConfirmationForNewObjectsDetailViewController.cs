using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace WinSolution.Module.Win {
    public class SuppressConfirmationForNewObjectsDetailViewController : ViewController<DetailView> {
        private WinModificationsController worker;
        protected override void OnActivated() {
            base.OnActivated();
            ObjectSpace.ObjectChanged += ObjectSpace_ObjectChanged;
            if (ObjectSpace.IsNewObject(View.CurrentObject)) {
                worker = Frame.GetController<WinModificationsController>();
                if (worker != null) {
                    worker.ModificationsHandlingMode = DevExpress.ExpressApp.SystemModule.ModificationsHandlingMode.AutoRollback;
                }
            }
        }
        protected override void OnDeactivated() {
            ObjectSpace.ObjectChanged -= ObjectSpace_ObjectChanged;
            worker = null;
            base.OnDeactivated();
        }
        private void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e) {
            if(worker != null) {
                worker.ModificationsHandlingMode = DevExpress.ExpressApp.SystemModule.ModificationsHandlingMode.Confirmation;
            }
        }
    }
    [DefaultClassOptions]
    public class DemoObject : BaseObject {
        public DemoObject(Session session) : base(session) { }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
    }
}