*Files to look at*: 
* [E2114.ets](./CS/E2114.EasyTests/E2114.ets) (VB: [E2114.ets](./VB/E2114.EasyTests/E2114.ets)) 
* **[SuppressConfirmationForNewObjectsDetailViewController.cs](./CS/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.cs) (VB: [SuppressConfirmationForNewObjectsDetailViewController.vb](./VB/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.vb))** 

# OBSOLETE - How to suppress the save confirmation when closing a new unmodified object DetailView


**==============================**  
**With XAF v19.2, we no longer show the save confirmation dialog when a user closes DetailView for a new unmodified object in a WinForms application. For more information, see [BC5122 - WinForms - The save confirmation dialog is not shown when closing DetailView for a new unmodified object](https://community.devexpress.com/forums/p/111817/381394.aspx).**   
**==============================**  

**Scenario**  
This example demonstrates how to implement the following behavior (which is default in Microsoft Outlook) in XAF Windows Forms applications:

- A user can create a new record, and when its detail form is opened he or she may close the form without entering any data (e.g., a new record was created by accident). In this case, the form can be closed without any save confirmation, because no user data needs to be saved.

- If a user enters some data into the form and then closes it, the save confirmation appears as expected not to lose entered data.  
To test it, run [<u>functional tests</u>](http://documentation.devexpress.com/#Xaf/CustomDocument3206) from the _E2114.EasyTests\E2114.ets_ folder.

**Steps to implement**  
Copy the _WinSolution.Module.Win\SuppressConfirmationForNewObjectsDetailViewController.xx_ file into _YourSolutionName.Module.Win_ project.

**Your feedback is needed!**  
We are hesitating to include the current implementation by default, because there are many ways to instantiate new objects in Views and it many cases it is difficult to uniquely state that an object is "untouched". For instance, you may have custom initialization code in the AfterConstruction or OnActivated methods of your business class or Controller, in the ObjectCreating, CustomCloneObject, ActionBase's Execute or other event handlers of standard and custom XAF UI entities.  
You and other readers can help us decide faster if you share your thoughts on whether this logic should cover any internal programmatic changes to objects (including Actions!) or should only consider a user touching data editors by hand. Thanks in advance.   

**See Also:**  
[WinModificationsController Class](http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWinSystemModuleWinModificationsControllertopic)
[ModificationsController.ModificationsHandlingMode](http://documentation.devexpress.com/#Xaf/DevExpressExpressAppSystemModuleModificationsController_ModificationsHandlingModetopic)
[Core - Disable the confirmation dialog when closing a form with a new object left untouched](https://www.devexpress.com/Support/Center/p/AS13212)
