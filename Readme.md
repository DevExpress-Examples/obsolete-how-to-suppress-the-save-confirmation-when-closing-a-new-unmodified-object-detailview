*Files to look at*: 
* [E2114.ets](./CS/E2114.EasyTests/E2114.ets) (VB: [E2114.ets](./VB/E2114.EasyTests/E2114.ets)) 
* **[SuppressConfirmationForNewObjectsDetailViewController.cs](./CS/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.cs) (VB: [SuppressConfirmationForNewObjectsDetailViewController.vb](./VB/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.vb))** 

# OBSOLETE - How to suppress the save confirmation when closing a new unmodified object DetailView

**Scenario**  
This example demonstrates how to implement the following behavior (which is default in Microsoft Outlook) in XAF Windows Forms applications:

- A user can create a new record, and when its detail form is opened he or she may close the form without entering any data (e.g., a new record was created by accident). In this case, the form can be closed without any save confirmation, because no user data needs to be saved.

- If a user enters some data into the form and then closes it, the save confirmation appears as expected not to lose entered data.  
To test it, run [<u>functional tests</u>](http://documentation.devexpress.com/#Xaf/CustomDocument3206) from the _E2114.EasyTests\E2114.ets_ folder.

**Steps to implement**  
**==============================**  
**With XAF v19.2, we no longer show the save confirmation dialog when a user closes DetailView for a new unmodified object in a WinForms application. You can also test the new behavior in v19.1.5 with one option (ConfirmCloseUnchangedNewObject). For more information, see this [breaking change](https://community.devexpress.com/forums/p/111817/381394.aspx).
The information below is still valid for versions prior to v19.2.**   
**==============================**  


To enable this feature in the older version, copy the _WinSolution.Module.Win\SuppressConfirmationForNewObjectsDetailViewController.xx_ file into _YourSolutionName.Module.Win_ project.

**See Also:**  
[WinModificationsController Class](http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWinSystemModuleWinModificationsControllertopic)
[ModificationsController.ModificationsHandlingMode](http://documentation.devexpress.com/#Xaf/DevExpressExpressAppSystemModuleModificationsController_ModificationsHandlingModetopic)
[Core - Disable the confirmation dialog when closing a form with a new object left untouched](https://www.devexpress.com/Support/Center/p/AS13212)
