namespace LiveConnectTest.Controls
{
    using LiveConnectTest.UIMaps.IOTGatewayUIMapClasses;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class IotGatewayControl
    {
        private readonly IOTGatewayUIMap _uiMap;
        private readonly UITypeheretosearchWindow _winSearch;
        private readonly UIHeaderList _headerList;
        private readonly WinList _winList;

        public IotGatewayControl()
        {
            this._uiMap = new IOTGatewayUIMap();
            this._winSearch = this._uiMap.UITypeheretosearchWindow;
            this._headerList = this._uiMap.UIIOTGateWayWindow.UIItemWindow.UIHeaderList;
            this._winList = this._uiMap.UIIOTGateWayWindow.UIShellViewWindow.UIShellViewClient.UIItemsViewList;
        }

        internal WinButton WindowsSearchButton
        {
            get { return this._winSearch.UITypeheretosearchButton; }
        }

        internal WinSplitButton DateModifiedButton
        {
            get { return this._headerList.UIDatemodifiedSplitButton; }
        }

        internal WinList IOTGatewayFolderListView
        {
            get { return this._winList; }
        }
    }
}
