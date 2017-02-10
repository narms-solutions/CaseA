

using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
namespace MobileTestCases
{
   public  class Acts
    {
       static IWebElement WorkOrder;
       public  static void CaseCUnplannedTask()
       {
           CaseCActivities activit = new CaseCActivities();
           CareServiceOrders activity = new CareServiceOrders();
           Thread.Sleep(2000);
           activit.CaseCUnplanned.Click();
           Thread.Sleep(1000);
           activit.StartAndEnd.Click();
           Thread.Sleep(1000);
           activit.TopSubscriber.Click();
           Thread.Sleep(1000);
           activit.KeyCustomer.Click();
           Thread.Sleep(1000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
           if (WorkOrder.Text.Trim() == "Sorry. Activities not found")
           {
               Console.WriteLine("Sorry. Activities not found!");
               //activit.Activities.Click();
               //Thread.Sleep(1000);
           }
           else
           {
               activit.Activities.Click();
               Thread.Sleep(1000);
               Console.WriteLine(WorkOrder.Text.Trim() + "\n");
           }
          
           Thread.Sleep(1000);
           activit.BackButton.Click();
           Thread.Sleep(1000);
           activity.LogoutButton.Click();
           Thread.Sleep(1000);
           activity.Logout.Click();
       }
       public static void CaseCDifferentCustomer()
       {
           CaseCActivities activity = new CaseCActivities();
           CareServiceOrders activities = new CareServiceOrders();
           Thread.Sleep(2000);
           activity.CaseCUnplanned.Click();
           Thread.Sleep(1000);
           activity.StartAndEnd.Click();
           Thread.Sleep(1000);
           activity.TopSubscriber.Click();
           Thread.Sleep(1000);
           activity.PreSchoolCustomer.Click();
           Thread.Sleep(1000);
           Thread.Sleep(1000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
           if (WorkOrder.Text.Trim() == "Sorry. Activities not found")
           {
               Console.WriteLine("Sorry. Activities not found!");
               //activit.Activities.Click();
               //Thread.Sleep(1000);
           }
           else
           {
               //activity.Activities.Click();
               //Thread.Sleep(1000);
               Console.WriteLine(WorkOrder.Text.Trim() + "\n");
           }
           Thread.Sleep(1000);
           activity.BackButton.Click();
           Thread.Sleep(1000);
           activities.LogoutButton.Click();
           Thread.Sleep(1000);
           activities.Logout.Click();
       }
       public static void CaseCareUnpalnnedContract()
       {
           CaseCActivities contract = new CaseCActivities();
           CareServiceOrders contact = new CareServiceOrders();
           Thread.Sleep(2000);
           contract.CaseCUnplanContractIndicator.Click();
           Thread.Sleep(1000);
           contract.CarinaSubscriber.Click();
           Thread.Sleep(1000);
           contract.Care.Click();
           Thread.Sleep(2000);
           contract.CaseCUnplanContractIndicator.Click();
           Thread.Sleep(1000);
           contract.EndButton.Click();
           Thread.Sleep(1000);
            WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
            Console.WriteLine(WorkOrder.Text.Trim() );
            Thread.Sleep(1000);
            contract.SaveButton.Click();
            Thread.Sleep(1000);
            contact.LogoutButton.Click();
            Thread.Sleep(1000);
            contact.Logout.Click();
       }
       public static void CaseServiceUnplannedContract()
       {
           CaseCActivities contract = new CaseCActivities();
           CareServiceOrders contact = new CareServiceOrders();
           Thread.Sleep(2000);
           contract.CaseCUnplanContractIndicator.Click();
           Thread.Sleep(1000);
           contract.CarinaSubscriber.Click();
           Thread.Sleep(1000);
           contract.Service.Click();
           Thread.Sleep(2000);
           contract.CaseCUnplanContractIndicator.Click();
           Thread.Sleep(1000);
           contract.EndButton.Click();
           Thread.Sleep(1000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           contract.SaveButton.Click();
           Thread.Sleep(1000);
           contact.LogoutButton.Click();
           Thread.Sleep(1000);
           contact.Logout.Click();
       }
       public static void CaseCMyWorkOrderTasks()
       {
           CaseCActivities order = new CaseCActivities();
           CareServiceOrders contacts = new CareServiceOrders();
           Thread.Sleep(1000);
           order.CMyWorkOrderTasks.Click();
           Thread.Sleep(1000);
           order.FirstDelivery.Click();
           Thread.Sleep(1000);
           order.StartandEndCheckBox.Click();
           Thread.Sleep(1000);
           order.StartDeliveryButton.Click();
           Thread.Sleep(1000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           order.BackToDeliveries.Click();
           Thread.Sleep(1000);
           order.BackToList.Click();
           Thread.Sleep(1000);
           order.BackMenu.Click();
           Thread.Sleep(1000);
           contacts.LogoutButton.Click();
           Thread.Sleep(1000);
           contacts.Logout.Click();
       }
       public static void CaseCSecondDeliveryWorkOrder()
       {
           CaseCActivities order = new CaseCActivities();
           CareServiceOrders contacts = new CareServiceOrders();
           Thread.Sleep(1000);
           order.CMyWorkOrderTasks.Click();
           Thread.Sleep(1000);
           order.SecondDelivery.Click();
           Thread.Sleep(1000);
           order.StartandEndCheckBox.Click();
           Thread.Sleep(1000);
           order.StartDeliveryButton.Click();
           Thread.Sleep(1000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           order.BackToDeliveries.Click();
           Thread.Sleep(1000);
           order.BackToList.Click();
           Thread.Sleep(1000);
           order.BackMenu.Click();
           Thread.Sleep(1000);
           contacts.LogoutButton.Click();
           Thread.Sleep(1000);
           contacts.Logout.Click();
       }
       public static void CaseDMyWorkOrderTasks()
       {
           CaseDTempChanges temp = new CaseDTempChanges();
           CareServiceOrders contacts = new CareServiceOrders();
           Thread.Sleep(1000);
           Thread.Sleep(1000);
           temp.CaseDMWOT.Click();
           Thread.Sleep(2000);
           temp.Nextday.Click();
           Thread.Sleep(2000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.order-list-container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           temp.BackButton.Click();
           Thread.Sleep(1000);
           contacts.LogoutButton.Click();
           Thread.Sleep(1000);
           contacts.Logout.Click();
       }
       public static void CaseENextDayMyWorkOrdertasks()
       {
           CaseDTempChanges temp = new CaseDTempChanges();
           CareServiceOrders contacts = new CareServiceOrders();
           Thread.Sleep(1000);
           temp.Nextday.Click();
           Thread.Sleep(2000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.order-list-container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           temp.BackButton.Click();
           Thread.Sleep(1000);
           contacts.LogoutButton.Click();
           Thread.Sleep(1000);
           contacts.Logout.Click();
       }
       public static void CaseETwoNextDayMyWorkOrdertasks()
       {
           CaseDTempChanges temp = new CaseDTempChanges();
           CareServiceOrders contacts = new CareServiceOrders();
           Thread.Sleep(1000);
           temp.Nextday.Click();
           Thread.Sleep(1000);
           temp.Nextday.Click();
           Thread.Sleep(2000);
           WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.order-list-container"));
           Console.WriteLine(WorkOrder.Text.Trim());
           Thread.Sleep(1000);
           temp.BackButton.Click();
           Thread.Sleep(1000);
           contacts.LogoutButton.Click();
           Thread.Sleep(1000);
           contacts.Logout.Click();
       }
       public static void CaseGTempResChange()
       {
           CaseGTempResourceChange resource = new CaseGTempResourceChange();
           IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
           Thread.Sleep(3000);
           js.ExecuteScript("window.scrollBy(0,500);");
           Thread.Sleep(1000);
           resource.CaseGChangeTodaysPlan.Click();
           Thread.Sleep(1000);
           resource.GretaCheckBox.Click();
           Thread.Sleep(1000);
           resource.SaveButton.Click();
           Thread.Sleep(1000);
           resource.BackButton.Click();

       }
       
    }
}
