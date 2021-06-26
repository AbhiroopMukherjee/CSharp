using LiveConnectTest.Controls;

namespace LiveConnectTest.TestMethods.IOTGateway
{
    using LiveConnectTest.UIPages;
    using LiveConnectTest.Utils;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;
    using System.Linq;
    using System.Threading;

    [CodedUITest]
    public class IotGatewayTestMethod
    {
        [TestMethod]
        public void InstallIotGateway()
        {
            //Initialize the IotGatewayPage class
            var iotGatewayPage = new IotGatewayPage();
            var iotGatewayControl = new IotGatewayControl();
            
            //Click on Windows Search button
            iotGatewayPage.ClickOnWinSearchButton();
            Thread.Sleep(1000);

            //Enter the build location
            iotGatewayPage.EnterBuildLocation();
            Thread.Sleep(1000);
            Keyboard.SendKeys("{ENTER}");

            //Sort the build folders according to date desc
            if(iotGatewayControl.IOTGatewayFolderListView.WaitForControlExist())
                iotGatewayPage.SortAccordingToDateModified();
        }
    }
}
