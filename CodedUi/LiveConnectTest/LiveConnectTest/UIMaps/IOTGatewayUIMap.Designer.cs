﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace LiveConnectTest.UIMaps.IOTGatewayUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class IOTGatewayUIMap
    {
        
        #region Properties
        public UITypeheretosearchWindow UITypeheretosearchWindow
        {
            get
            {
                if ((this.mUITypeheretosearchWindow == null))
                {
                    this.mUITypeheretosearchWindow = new UITypeheretosearchWindow();
                }
                return this.mUITypeheretosearchWindow;
            }
        }
        
        public UIIOTGateWayWindow UIIOTGateWayWindow
        {
            get
            {
                if ((this.mUIIOTGateWayWindow == null))
                {
                    this.mUIIOTGateWayWindow = new UIIOTGateWayWindow();
                }
                return this.mUIIOTGateWayWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITypeheretosearchWindow mUITypeheretosearchWindow;
        
        private UIIOTGateWayWindow mUIIOTGateWayWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITypeheretosearchWindow : WinWindow
    {
        
        public UITypeheretosearchWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Type here to search";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("Type here to search");
            #endregion
        }
        
        #region Properties
        public WinButton UITypeheretosearchButton
        {
            get
            {
                if ((this.mUITypeheretosearchButton == null))
                {
                    this.mUITypeheretosearchButton = new WinButton(this);
                    #region Search Criteria
                    this.mUITypeheretosearchButton.SearchProperties[WinButton.PropertyNames.Name] = "Type here to search";
                    this.mUITypeheretosearchButton.WindowTitles.Add("Type here to search");
                    #endregion
                }
                return this.mUITypeheretosearchButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUITypeheretosearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIIOTGateWayWindow : WinWindow
    {
        
        public UIIOTGateWayWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "IOTGateWay";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("IOTGateWay");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIShellViewWindow UIShellViewWindow
        {
            get
            {
                if ((this.mUIShellViewWindow == null))
                {
                    this.mUIShellViewWindow = new UIShellViewWindow(this);
                }
                return this.mUIShellViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIShellViewWindow mUIShellViewWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("IOTGateWay");
            #endregion
        }
        
        #region Properties
        public UIHeaderList UIHeaderList
        {
            get
            {
                if ((this.mUIHeaderList == null))
                {
                    this.mUIHeaderList = new UIHeaderList(this);
                }
                return this.mUIHeaderList;
            }
        }
        #endregion
        
        #region Fields
        private UIHeaderList mUIHeaderList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHeaderList : WinList
    {
        
        public UIHeaderList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinList.PropertyNames.Name] = "Header";
            this.WindowTitles.Add("IOTGateWay");
            #endregion
        }
        
        #region Properties
        public WinSplitButton UIDatemodifiedSplitButton
        {
            get
            {
                if ((this.mUIDatemodifiedSplitButton == null))
                {
                    this.mUIDatemodifiedSplitButton = new WinSplitButton(this);
                    #region Search Criteria
                    this.mUIDatemodifiedSplitButton.SearchProperties[WinButton.PropertyNames.Name] = "Date modified";
                    this.mUIDatemodifiedSplitButton.WindowTitles.Add("IOTGateWay");
                    #endregion
                }
                return this.mUIDatemodifiedSplitButton;
            }
        }
        #endregion
        
        #region Fields
        private WinSplitButton mUIDatemodifiedSplitButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIShellViewWindow : WinWindow
    {
        
        public UIShellViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShellView";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SHELLDLL_DefView";
            this.WindowTitles.Add("IOTGateWay");
            #endregion
        }
        
        #region Properties
        public UIShellViewClient UIShellViewClient
        {
            get
            {
                if ((this.mUIShellViewClient == null))
                {
                    this.mUIShellViewClient = new UIShellViewClient(this);
                }
                return this.mUIShellViewClient;
            }
        }
        #endregion
        
        #region Fields
        private UIShellViewClient mUIShellViewClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIShellViewClient : WinClient
    {
        
        public UIShellViewClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Shell Folder View";
            this.WindowTitles.Add("IOTGateWay");
            #endregion
        }
        
        #region Properties
        public WinList UIItemsViewList
        {
            get
            {
                if ((this.mUIItemsViewList == null))
                {
                    this.mUIItemsViewList = new WinList(this);
                    #region Search Criteria
                    this.mUIItemsViewList.SearchProperties[WinList.PropertyNames.Name] = "Items View";
                    this.mUIItemsViewList.WindowTitles.Add("IOTGateWay");
                    #endregion
                }
                return this.mUIItemsViewList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemsViewList;
        #endregion
    }
}