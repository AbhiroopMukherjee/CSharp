using System;
using System.Drawing.Text;
using LiveConnectTest.Controls;

namespace LiveConnectTest.UIPages
{
    using LiveConnectTest.Actions;
    using LiveConnectTest.Utils;
    using System.IO;
    using System.Linq;

    public class IotGatewayPage
    {
        private readonly IotGatewayAction _iotGatewayAction;

        public IotGatewayPage()
        {
            this._iotGatewayAction = new IotGatewayAction();
        }

        public void ClickOnWinSearchButton()
        {
            this._iotGatewayAction.ClickOnWinSearchButton();
        }

        public void EnterBuildLocation()
        {
            this._iotGatewayAction.EnterBuildLocation();
        }

        public void SortAccordingToDateModified()
        {
            this._iotGatewayAction.ClickOnDateModifiedButton();
        }
    }
}
