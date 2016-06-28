using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TokenAssistant;
using System.Collections.Generic;

namespace UnitTestTokenTool
{
    [TestClass]
    public class AzureAppServiceTest
    {
        //[TestMethod]
        //public void TestAddGet()
        //{
        //    XMLAzureAppService appService = new XMLAzureAppService();
        //    AzureApp app = new AzureApp { AppName = "Office365RESTFEI", ClientId = "5efa8abc-13dc-4681-83f5-c6fde07116ac"};
        //    appService.AddApp(app);


        //    XMLAzureAppService appServiceNew = new XMLAzureAppService();
        //    AzureApp appNew = appServiceNew.GetApp("5efa8abc-13dc-4681-83f5-c6fde07116ac");

        //    Assert.AreEqual(app.ClientId, appNew.ClientId);
        //    Assert.AreEqual(app.AppName, appNew.AppName);
        //    Assert.AreEqual(app.RedirectURL, appNew.RedirectURL);
        //}

        //[TestMethod]
        //public void TestGetAll()
        //{
        //    XMLAzureAppService appService = new XMLAzureAppService();
        //    AzureApp app1 = new AzureApp
        //    {
        //        AppName = "Office365RESTFEI",
        //        ClientId = "5efa8abc-13dc-4681-83f5-c6fde07116ac",
        //        Secret = "+ae67Jr3Pdl3F4JcCWOfnoURa9WTzRmzaBOySXeGdVY=",
        //        RedirectURL = "http://localhost:55065",
        //        Resource = "https://graph.microsoft.com"
        //    };

        //    AzureApp app2 = new AzureApp
        //    {
        //        AppName = "Office365RESTFEI2",
        //        ClientId = "eae75bf2-a987-48b3-ac87-0f2a1700adab",
        //        Secret = "+ae67Jr3Pdl3F4JcCWOfnoURa9WTzRmzaBOySXeGdVY=",
        //        RedirectURL = "http://localhost:55065",
        //        Resource = "https://graph.microsoft.com"
        //    };
           

        //    List<AzureApp> expectedApps = new List<AzureApp>();
        //    expectedApps.Add(app1);
        //    expectedApps.Add(app2);

        //    appService.ClearApps();
        //    appService.AddApp(app1);
        //    appService.AddApp(app2);
        //    CollectionAssert.AreEqual(expectedApps, appService.GetAllApps());


        //}
    }
}
