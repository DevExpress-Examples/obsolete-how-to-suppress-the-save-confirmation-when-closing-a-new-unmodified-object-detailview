using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.SystemModule;

namespace WinSolution.Module.Win {
    public class SuppressConfirmationForNewObjectsDetailViewController : ViewController<DetailView> {
        private WinDetailViewController worker;
        protected override void OnActivated() {
            base.OnActivated();
            ObjectSpace.ObjectChanged += ObjectSpace_ObjectChanged;
            if (ObjectSpace.IsNewObject(View.CurrentObject)) {
                worker = Frame.GetController<WinDetailViewController>();
                worker.SuppressConfirmation = true;
            }
        }
        protected override void OnDeactivated() {
            ObjectSpace.ObjectChanged -= ObjectSpace_ObjectChanged;
            base.OnDeactivated();
        }
        private void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e) {
            if (worker != null)
                worker.SuppressConfirmation = false;
        }
    }
}