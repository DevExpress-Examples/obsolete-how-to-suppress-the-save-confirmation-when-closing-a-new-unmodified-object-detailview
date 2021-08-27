<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2114)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[SuppressConfirmationForNewObjectsDetailViewController.cs](./CS/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.cs) (VB: [SuppressConfirmationForNewObjectsDetailViewController.vb](./VB/WinSolution.Module.Win/SuppressConfirmationForNewObjectsDetailViewController.vb))**
<!-- default file list end -->
# How to suppress the save confirmation when closing a new unmodified object DetailView


<p><strong>Scenario</strong><br> This example demonstrates how to implement the following behavior (which is default in Microsoft Outlook) in XAF Windows Forms applications:</p>
<p>- A user can create a new record, and when its detail form is opened he or she may close the form without entering any data (e.g., a new record was created by accident). In this case, the form can be closed without any save confirmation, because no user data needs to be saved.</p>
<p>- If a user enters some data into the form and then closes it, the save confirmation appears as expected not to lose entered data.<br>To test it, run <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3206"><u>functional tests</u></a> from the <em>E2114.EasyTests\E2114.ets</em> folder.</p>
<p> </p>
<p><strong>Steps to implement</strong><br> Copy the <em>WinSolution.Module.Win\SuppressConfirmationForNewObjectsDetailViewController.xx</em> file into <em>YourSolutionName.Module.Win</em> project.</p>
<p><br><strong>Your feedback is needed!</strong><br>We are hesitating to include the current implementation by default, because there are many ways to instantiate new objects in Views and it many cases it is difficult to uniquely state that an object is "untouched". For instance, you may have custom initialization code in the AfterConstruction or OnActivated methods of your business class or Controller, in the ObjectCreating, CustomCloneObject, ActionBase's Execute or other event handlers of standard and custom XAF UI entities.<br>You and other readers can help us decide faster if you share your thoughts on whether this logic should cover any internal programmatic changes to objects (including Actions!) or should only consider a user touching data editors by hand. Thanks in advance. <br><br></p>
<p><strong>See Also:</strong><br> <a href="http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWinSystemModuleWinModificationsControllertopic"><u>WinModificationsController Class</u></a><u><br> </u><a href="http://documentation.devexpress.com/#Xaf/DevExpressExpressAppSystemModuleModificationsController_ModificationsHandlingModetopic"><u>ModificationsController.ModificationsHandlingMode</u></a><u><br> </u><a href="https://www.devexpress.com/Support/Center/p/AS13212">Core - Disable the confirmation dialog when closing a form with a new object left untouched</a></p>

<br/>


