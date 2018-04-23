using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.SystemModule;

namespace WinSolution.Module.Win {
    public class MyWinNewObjectViewController : WinNewObjectViewController {
        protected override void OnAfterConstruction() {
            base.OnAfterConstruction();
        }
        protected override void OnActivated() {
            base.OnActivated();
            if (View.ObjectType==typeof(DomainObject1)){
                this.NewObjectAction.Caption = "Add";                
            }
        }
        protected override void OnDeactivating() {
            base.OnDeactivating();
            if (View.ObjectType == typeof(DomainObject1)) {
                this.NewObjectAction.Caption = "New";
            }
        }
    }
}
