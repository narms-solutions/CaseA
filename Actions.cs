

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using MobileTestCases;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Events;
using NUnit.Framework;

namespace MobileTestCases
{
    public class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        static IWebElement WorkOrder;
        static IWebElement WorkOrderNextDay;
        public static void DayLoginCredentials(string UserName, string Pasword)
        //     public static void DayLoginCredentials(string MobileNumber,string UserName, string Pasword)
        {
            LoginPage loginpage = new LoginPage();
            //loginpage.MobileNumber.SendKeys(MobileNumber);
            //loginpage.OKButton.Click();
            loginpage.UserName.Clear();
            loginpage.UserName.SendKeys(UserName);
            loginpage.Password.Clear();
            loginpage.Password.SendKeys(Pasword);
            loginpage.LoginButton.Click();
        }
        public static void CareCredentials( string MobileNumber,string UserCare, string Pasword)
        {
            LoginPage loginpage = new LoginPage();
            loginpage.MobileNumber.SendKeys(MobileNumber);
            loginpage.OKButton.Click();
            loginpage.UserName.Clear();
            loginpage.UserName.SendKeys(UserCare);
            loginpage.Password.Clear();
            loginpage.Password.SendKeys(Pasword);
            loginpage.LoginButton.Click();

        }
        public static void ServiceCredentials(string UserName, string Pasword)
        {
           
            LoginPage loginpage = new LoginPage();
            //loginpage.MobileNumber.SendKeys(MobileNumber);
            //loginpage.OKButton.Click();
            loginpage.UserName.Clear();
            loginpage.UserName.SendKeys(UserName);
            loginpage.Password.Clear();
            loginpage.Password.SendKeys(Pasword);
            loginpage.LoginButton.Click();
        }

        public static void FoodCredentials(string UserName, string Pasword)
        {

            LoginPage loginpage = new LoginPage();
            //loginpage.MobileNumber.SendKeys(MobileNumber);
            //loginpage.OKButton.Click();
            loginpage.UserName.Clear();
            loginpage.UserName.SendKeys(UserName);
            loginpage.Password.Clear();
            loginpage.Password.SendKeys(Pasword);
            loginpage.LoginButton.Click();
        }
        public static void CareServiceCredentials(string UserName, string Pasword)
        {

            LoginPage loginpage = new LoginPage();
            //loginpage.MobileNumber.SendKeys(MobileNumber);
            //loginpage.OKButton.Click();
            loginpage.UserName.Clear();
            loginpage.UserName.SendKeys(UserName);
            loginpage.Password.Clear();
            loginpage.Password.SendKeys(Pasword);
            loginpage.LoginButton.Click();
        }
        public static void DayMyOrderTasks()
        {
            CaseA5WorkOrderTasks WOTasks = new CaseA5WorkOrderTasks();
            Thread.Sleep(1000);
            WOTasks.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            //Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            //String fp = @"C:\Users\narms\Desktop\CaseA\" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png";
            //ss.SaveAsFile(fp, System.Drawing.Imaging.ImageFormat.Png);
            IList<IWebElement> subelements = WOTasks.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for Day user: " + WOTasks.WholePage.FindElements(By.ClassName("order-item")).Count);  //Count=4 
            Assert.AreEqual(subelements.Count, 4);
            WOTasks.BackButton.Click();
            Thread.Sleep(3000);
            WOTasks.ChangeMYOrderTasks.Click();
            Thread.Sleep(3000);
            WOTasks.MyOrderArrow.Click();
            Thread.Sleep(3000);
            IList<IWebElement> subelementsList = WOTasks.OrdersContainer.FindElements(By.ClassName("delivery_row_item"));
            Console.WriteLine("Number of orders in Change My Work Orders: " + WOTasks.OrdersContainer.FindElements(By.ClassName("delivery_row_item")).Count);     //Count= 2+2(Unplanned Tasks)=4
            Assert.AreEqual(subelementsList.Count, 2);
            Thread.Sleep(1000);
            WOTasks.BackToOrders.Click();
            Thread.Sleep(1000);
            WOTasks.BackToMenu.Click();
            Thread.Sleep(1000);
            WOTasks.LogoutButton.Click();
            Thread.Sleep(1000);
            WOTasks.Logout.Click();
        }
        public static void careMyOrderTasks()
        {
            CareMyOrderTasks CareOrders = new CareMyOrderTasks();
            Thread.Sleep(3000);
            CareOrders.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            //Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            //String fp = @"C:\Users\narms\Desktop\CaseA\" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png";
            //ss.SaveAsFile(fp, System.Drawing.Imaging.ImageFormat.Png);
            IList<IWebElement> subelements = CareOrders.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for Care user: " + CareOrders.WholePage.FindElements(By.ClassName("order-item")).Count); //Count=6
            Assert.AreEqual(subelements.Count, 6);
            CareOrders.BackButton.Click();
            Thread.Sleep(1000);
            CareOrders.ChangeMYOrderTasks.Click();
            Thread.Sleep(1000);
            CareOrders.MYOrderArrow.Click();
            IList<IWebElement> subelementsList = CareOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item"));
            Console.WriteLine("Number of orders in Change My Work Orders: " + CareOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item")).Count); //Count=6
            Assert.AreEqual(subelementsList.Count, 6);
            Thread.Sleep(1000);
            CareOrders.BackToOrders.Click();
            Thread.Sleep(1000);
            CareOrders.BackToMenu.Click();
            Thread.Sleep(1000);
            CareOrders.LogoutButton.Click();
            Thread.Sleep(1000);
            CareOrders.Logout.Click();
            Thread.Sleep(3000);

        }
        public static void ServiceMYOrderTasks()
        {
            ServiceMyOrderTasks ServiceOrders = new ServiceMyOrderTasks();
            Thread.Sleep(3000);
            ServiceOrders.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            IList<IWebElement> subelements = ServiceOrders.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for Service user: " + ServiceOrders.WholePage.FindElements(By.ClassName("order-item")).Count);  //count=10
            Assert.AreEqual(subelements.Count, 10);
            ServiceOrders.BackButton.Click();
            Thread.Sleep(1000);
            ServiceOrders.ChangeMYOrderTasks.Click();
            Thread.Sleep(1000);
            ServiceOrders.MYOrderArrow.Click();
            IList<IWebElement> subelementsList = ServiceOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item"));
            Console.WriteLine("Number of orders in Change My Work Orders:" + ServiceOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item")).Count);  //count=7 (3 are Unplanned orders)
            Assert.AreEqual(subelementsList.Count, 7);
            Thread.Sleep(1000);
            ServiceOrders.BackToOrders.Click();
            Thread.Sleep(1000);
            ServiceOrders.BackToMenu.Click();
            Thread.Sleep(1000);
            ServiceOrders.LogoutButton.Click();
            Thread.Sleep(1000);
            ServiceOrders.Logout.Click();

        }
        public static void FoodMYOrderTasks()
        {
            FoodMyOrderTasks FoodOrders = new FoodMyOrderTasks();
            Thread.Sleep(3000);
            FoodOrders.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            IList<IWebElement> subelements = FoodOrders.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for Food user: " + FoodOrders.WholePage.FindElements(By.ClassName("order-item")).Count);  //Count=18
            Assert.AreEqual(subelements.Count, 18);
            FoodOrders.BackButton.Click();
            Thread.Sleep(1000);
            FoodOrders.ChangeMYOrderTasks.Click();
            Thread.Sleep(1000);
            FoodOrders.MYOrderArrow.Click();
            Thread.Sleep(1000);
            IList<IWebElement> subelementsList = FoodOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item"));
            Console.WriteLine("Number of orders in Change My Work Orders: " + FoodOrders.OrdersContainer.FindElements(By.ClassName("delivery_row_item")).Count);    //Count=18
            Assert.AreEqual(subelements.Count, 18);
            Thread.Sleep(1000);
            FoodOrders.BackToOrders.Click();
            Thread.Sleep(1000);
            FoodOrders.BackToMenu.Click();
            Thread.Sleep(1000);
            FoodOrders.LogoutButton.Click();
            Thread.Sleep(1000);
            FoodOrders.Logout.Click();
        }

        public static void SelectCareTasks()         //Care is not assigned to any scheme Row.So, ChangeMYOrderTasks is not testing for this account
        {
            CareServiceOrders CareService = new CareServiceOrders();  
            Thread.Sleep(3000);
            CareService.ACare.Click();
            Thread.Sleep(3000);
            CareService.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            IList<IWebElement> subelements = CareService.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for Acare user: " + CareService.WholePage.FindElements(By.ClassName("order-item")).Count);
            Assert.AreEqual(subelements.Count, 0);
            CareService.BackButton.Click();
            Thread.Sleep(1000);
            CareService.LogoutButton.Click();
            Thread.Sleep(1000);
            CareService.Logout.Click();
        }

        public static void SelectServiceTasks()   //Service is assigned to scheme row nut has no orders. So, ChangeMYOrderTasks is not testing for this account
        {
            CareServiceOrders CareService = new CareServiceOrders();
            Thread.Sleep(3000);
            CareService.AService.Click();
            Thread.Sleep(3000);
            CareService.MyWorkOrderTask.Click();
            Thread.Sleep(3000);
            IList<IWebElement> subelements = CareService.WholePage.FindElements(By.ClassName("order-item"));
            Console.WriteLine("Number of orders found for AService user: " + CareService.WholePage.FindElements(By.ClassName("order-item")).Count);
            Assert.AreEqual(subelements.Count, 2);
            CareService.BackButton.Click();
            Thread.Sleep(1000);
            CareService.LogoutButton.Click();
            Thread.Sleep(1000);
            CareService.Logout.Click();
        }
        public static void CaseBMobilAttendance()
        {
            CaseBMobileAttendance attend = new CaseBMobileAttendance();
            CareServiceOrders attendservice = new CareServiceOrders();
            Thread.Sleep(1000);
            attend.CaseBAttend.Click();
            Thread.Sleep(1000);
            IList<IWebElement> subelements = attend.AttendanceContainer.FindElements(By.ClassName("user-item"));
            Thread.Sleep(1000);
            Console.WriteLine("Number of orders found for AService user: " + attend.AttendanceContainer.FindElements(By.ClassName("user-item")).Count);
            Thread.Sleep(1000);
            //Assert.AreEqual(subelements.Count, 21);
            //Thread.Sleep(1000);
            attend.BackButton.Click();
            Thread.Sleep(1000);
            attendservice.LogoutButton.Click();
            Thread.Sleep(1000);
            attendservice.Logout.Click();
        }

        public static void CaseBWorkshift()
        {
            CaseBMobileAttendance workshift = new CaseBMobileAttendance();
            CareServiceOrders work = new CareServiceOrders();
            Thread.Sleep(2000);
            workshift.CaseBWorkShift.Click();
            IList<IWebElement> subelements = workshift.WorkshiftContainer.FindElements(By.ClassName("user-item-content"));
            Thread.Sleep(2000);
            Console.WriteLine("Number of attendies for user : "+ workshift.WorkshiftContainer.FindElements(By.ClassName("user-item-content")).Count);
            Thread.Sleep(2000);
           // Assert.AreEqual(subelements.Count, 1);
            Thread.Sleep(2000);
            workshift.BackButton.Click();
            Thread.Sleep(2000);
            work.LogoutButton.Click();
            Thread.Sleep(2000);
            work.Logout.Click();
        }
        public static void CaseBCOrderDeliveries()
        {
            CaseBMobileAttendance order = new CaseBMobileAttendance();
            CareServiceOrders delivery = new CareServiceOrders();
            Thread.Sleep(1000);
            order.CaseBWorkOrderDeliveries.Click();
            Thread.Sleep(1000);
            IList<IWebElement> subelements = order.OrderDeliveryContainer.FindElements(By.ClassName("order-item"));
            Thread.Sleep(1000);

            for (int option = 1; option < subelements.Count +1; option++)
            {
                WorkOrder = Driver.driver.FindElement(By.CssSelector("  #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + option + ")"));
                Console.WriteLine(WorkOrder.Text.Trim()+ "\n");
            }
            Thread.Sleep(1000);
            Console.WriteLine("Number of attendies for user : " + order.OrderDeliveryContainer.FindElements(By.ClassName("order-item")).Count + "\n");
            Thread.Sleep(1000);
            order.NextdayButton.Click();
            IList<IWebElement> subelements1 = order.OrderDeliveryContainer.FindElements(By.ClassName("order-item"));
            Thread.Sleep(1000);

            for (int option = 1; option < subelements.Count + 1; option++)
            {
                WorkOrderNextDay = Driver.driver.FindElement(By.CssSelector("  #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + option + ")"));
                Console.WriteLine(WorkOrderNextDay.Text.Trim() + "\n");

            }
           
            Thread.Sleep(1000);
            Console.WriteLine("Number of attendies for user : " + order.OrderDeliveryContainer.FindElements(By.ClassName("order-item")).Count + "\n");
            Thread.Sleep(1000);
            order.Back.Click();
            Thread.Sleep(1000);
            delivery.LogoutButton.Click();
            Thread.Sleep(1000);
            delivery.Logout.Click();

        }
        public static void ArvidCaseBCOrderDeliveries()
        {
            CaseBMobileAttendance order = new CaseBMobileAttendance();
            CareServiceOrders delivery = new CareServiceOrders();
            Thread.Sleep(2000);
            order.CaseBWorkOrderDeliveries.Click();
            Thread.Sleep(1000);
            IList<IWebElement> subelements = order.OrderDeliveryContainer.FindElements(By.ClassName("order-item"));
            Thread.Sleep(1000);

            for (int option = 1; option < subelements.Count + 1; option++)
            {
                WorkOrder = Driver.driver.FindElement(By.CssSelector("  #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + option + ")"));
                Console.WriteLine(WorkOrder.Text.Trim() + "\n");
            }
            Thread.Sleep(1000);
            Console.WriteLine("Number of attendies for user : " + order.OrderDeliveryContainer.FindElements(By.ClassName("order-item")).Count + "\n");
            Thread.Sleep(1000);
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            IList<IWebElement> subelements1 = order.OrderDeliveryContainer.FindElements(By.ClassName("order-item"));
            Thread.Sleep(1000);

            for (int option = 1; option < subelements1.Count + 1; option++)
            {
                WorkOrderNextDay = Driver.driver.FindElement(By.CssSelector("  #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + option + ")"));
                Console.WriteLine(WorkOrderNextDay.Text.Trim() + "\n");

            }

            Thread.Sleep(1000);
            Console.WriteLine("Number of attendies for user : " + order.OrderDeliveryContainer.FindElements(By.ClassName("order-item")).Count + "\n");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            order.NextdayButton.Click();
            IList<IWebElement> subelements2 = order.OrderDeliveryContainer.FindElements(By.ClassName("order-item"));
            Thread.Sleep(1000);

            for (int option = 1; option < subelements2.Count + 1; option++)
            {
                WorkOrderNextDay = Driver.driver.FindElement(By.CssSelector("  #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + option + ")"));
                Console.WriteLine(WorkOrderNextDay.Text.Trim() + "\n");

            }

            Thread.Sleep(1000);
            Console.WriteLine("Number of attendies for user : " + order.OrderDeliveryContainer.FindElements(By.ClassName("order-item")).Count + "\n");
            Thread.Sleep(1000);
            order.Back.Click();
            Thread.Sleep(1000);
            delivery.LogoutButton.Click();
            Thread.Sleep(1000);
            delivery.Logout.Click();

        }
        public static void CaseBDchandeMyworkOrder()
        {
            CaseBMobileAttendance change = new CaseBMobileAttendance();
            CareServiceOrders ChangeOrder = new CareServiceOrders();
            Thread.Sleep(1000);
            change.ChangeTodaysWorkOrder.Click();
            Thread.Sleep(1000);
            WorkOrder = Driver.driver.FindElement(By.ClassName("delivery_count"));
            string NumberofOrders = WorkOrder.Text.Trim();         
            Console.WriteLine(NumberofOrders);                      
            change.ChangeBackButton.Click();
            Thread.Sleep(1000);
            ChangeOrder.LogoutButton.Click();
            Thread.Sleep(1000);
            ChangeOrder.Logout.Click();

        }
        public static void CaseBSettingsAttendance(string SecretKey)
        {
            CaseBMobileAttendance setting =new CaseBMobileAttendance();
            CareServiceOrders attnd = new CareServiceOrders();
            Thread.Sleep(1000);
            setting.CaseBAttend.Click();
            Thread.Sleep(1000);
            setting.AttendanceSettings.Click();
            Thread.Sleep(1000);
            setting.SendPassword.SendKeys(SecretKey);
            Thread.Sleep(1000);
            setting.KeyOkButton.Click();
            for (int i = 1; i < 5; i++)
            {
                WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div.container > div.main-content > div > div:nth-child(1) > div:nth-child(2) > div:nth-child("+  i +") > label"));
                WorkOrder.Click();                                    
            }
            setting.Presence.Click();
            Thread.Sleep(1000);
            IList<IWebElement> subelements = setting.AttendanceContainer.FindElements(By.ClassName("user-item"));
            Thread.Sleep(1000);
            Console.WriteLine("Number of orders found for AService user: " + setting.AttendanceContainer.FindElements(By.ClassName("user-item")).Count);
            Thread.Sleep(1000);
            //Assert.AreEqual(subelements.Count, 21);
            //Thread.Sleep(1000);
            setting.BackButton.Click();
            Thread.Sleep(1000);
            attnd.LogoutButton.Click();
            Thread.Sleep(1000);
            attnd.Logout.Click();
        }

        public static void CaseBOfficeWorkShiftService()
        {
            CaseBMobileAttendance office = new CaseBMobileAttendance();
            Thread.Sleep(1000);
            office.caseBOrgUnit.Click();
            Thread.Sleep(1000);
            Actions.CaseBWorkshift();




        }
    }

}

