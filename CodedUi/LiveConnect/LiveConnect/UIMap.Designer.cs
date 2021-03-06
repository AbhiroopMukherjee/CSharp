// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 16.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace LiveConnect
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
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public partial class UIMap
    {
        
        /// <summary>
        /// DPSTest - Use 'DPSTestParams' to pass parameters into this method.
        /// </summary>
        public void DPSTest()
        {
            #region Variable Declarations
            WinTitleBar uIItemTitleBar = this.UIItemWindow.UIItemTitleBar;
            WpfToggleButton uIMenuToggleButtonToggleButton = this.UIWpfWindow.UIMenuToggleButtonToggleButton;
            WpfCheckBox uIQCResultCheckBox = this.UIWpfWindow.UIMessageTypeSelectonlGroup.UIListitemsList.UIRadiometerLiveConnecListItem.UIQCResultCheckBox;
            WpfButton uISendButton = this.UIWpfWindow.UIItemCustom.UISimulationActionsGroup.UISendButton;
            WpfButton uICheckConnectionButton = this.UIWpfWindow.UIItemCustom.UISimulationActionsGroup.UICheckConnectionButton;
            WpfListItem LiveConnectListItem = this.UIWpfWindow.UISupportedDeviceListBList.UIItemListItem;
            #endregion

            // Click title bar
            Mouse.Click(uIItemTitleBar, new Point(1006, 15));

            // Set to 'Pressed' state 'MenuToggleButton' toggle button
            uIMenuToggleButtonToggleButton.Pressed = this.DPSTestParams.UIMenuToggleButtonToggleButtonPressed;

            // Last action on list item was not recorded because the control does not have any good identification property.
            Mouse.Click(LiveConnectListItem);

            // Select 'QC Result' check box
            uIQCResultCheckBox.Checked = this.DPSTestParams.UIQCResultCheckBoxChecked;

            // Click 'Send' button
            Mouse.Click(uISendButton, new Point(30, 13));

            // Click 'Check Connection' button
            Mouse.Click(uICheckConnectionButton, new Point(79, 19));

            // Click 'Send' button
            Mouse.Click(uISendButton, new Point(52, 11));

        }

        #region Properties
        public virtual DPSTestParams DPSTestParams
        {
            get
            {
                if ((this.mDPSTestParams == null))
                {
                    this.mDPSTestParams = new DPSTestParams();
                }
                return this.mDPSTestParams;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow();
                }
                return this.mUIWpfWindow;
            }
        }
        #endregion
        
        #region Fields
        private DPSTestParams mDPSTestParams;
        
        private UIItemWindow mUIItemWindow;
        
        private UIWpfWindow mUIWpfWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'DPSTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class DPSTestParams
    {
        
        #region Fields
        /// <summary>
        /// Set to 'Pressed' state 'MenuToggleButton' toggle button
        /// </summary>
        public bool UIMenuToggleButtonToggleButtonPressed = true;
        
        /// <summary>
        /// Select 'QC Result' check box
        /// </summary>
        public bool UIQCResultCheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop 1";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIItemTitleBar
        {
            get
            {
                if ((this.mUIItemTitleBar == null))
                {
                    this.mUIItemTitleBar = new WinTitleBar(this);
                }
                return this.mUIItemTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIItemTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public WpfToggleButton UIMenuToggleButtonToggleButton
        {
            get
            {
                if ((this.mUIMenuToggleButtonToggleButton == null))
                {
                    this.mUIMenuToggleButtonToggleButton = new WpfToggleButton(this);
                    #region Search Criteria
                    this.mUIMenuToggleButtonToggleButton.SearchProperties[WpfToggleButton.PropertyNames.AutomationId] = "MenuToggleButton";
                    #endregion
                }
                return this.mUIMenuToggleButtonToggleButton;
            }
        }
        
        public UIMessageTypeSelectonlGroup UIMessageTypeSelectonlGroup
        {
            get
            {
                if ((this.mUIMessageTypeSelectonlGroup == null))
                {
                    this.mUIMessageTypeSelectonlGroup = new UIMessageTypeSelectonlGroup(this);
                }
                return this.mUIMessageTypeSelectonlGroup;
            }
        }
        
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }
        
        public UISupportedDeviceListBList UISupportedDeviceListBList
        {
            get
            {
                if ((this.mUISupportedDeviceListBList == null))
                {
                    this.mUISupportedDeviceListBList = new UISupportedDeviceListBList(this);
                }
                return this.mUISupportedDeviceListBList;
            }
        }
        #endregion
        
        #region Fields
        private WpfToggleButton mUIMenuToggleButtonToggleButton;
        
        private UIMessageTypeSelectonlGroup mUIMessageTypeSelectonlGroup;
        
        private UIItemCustom mUIItemCustom;
        
        private UISupportedDeviceListBList mUISupportedDeviceListBList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIMessageTypeSelectonlGroup : WpfGroup
    {
        
        public UIMessageTypeSelectonlGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.Name] = "Message Type (Select only one type if you testing single message)";
            #endregion
        }
        
        #region Properties
        public UIListitemsList UIListitemsList
        {
            get
            {
                if ((this.mUIListitemsList == null))
                {
                    this.mUIListitemsList = new UIListitemsList(this);
                }
                return this.mUIListitemsList;
            }
        }
        #endregion
        
        #region Fields
        private UIListitemsList mUIListitemsList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIListitemsList : WpfList
    {
        
        public UIListitemsList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "Listitems";
            #endregion
        }
        
        #region Properties
        public UIRadiometerLiveConnecListItem UIRadiometerLiveConnecListItem
        {
            get
            {
                if ((this.mUIRadiometerLiveConnecListItem == null))
                {
                    this.mUIRadiometerLiveConnecListItem = new UIRadiometerLiveConnecListItem(this);
                }
                return this.mUIRadiometerLiveConnecListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIRadiometerLiveConnecListItem mUIRadiometerLiveConnecListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIRadiometerLiveConnecListItem : WpfListItem
    {
        
        public UIRadiometerLiveConnecListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfListItem.PropertyNames.Name] = "Radiometer.LiveConnect.DataSimulator.Devices.ABL800.MessageTypeListItem";
            this.SearchProperties[WpfListItem.PropertyNames.Instance] = "9";
            #endregion
        }
        
        #region Properties
        public WpfCheckBox UIQCResultCheckBox
        {
            get
            {
                if ((this.mUIQCResultCheckBox == null))
                {
                    this.mUIQCResultCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUIQCResultCheckBox.SearchProperties[WpfCheckBox.PropertyNames.Name] = "QC Result";
                    #endregion
                }
                return this.mUIQCResultCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WpfCheckBox mUIQCResultCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIItemCustom : WpfCustom
    {
        
        public UIItemCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.ABL800";
            #endregion
        }
        
        #region Properties
        public UISimulationActionsGroup UISimulationActionsGroup
        {
            get
            {
                if ((this.mUISimulationActionsGroup == null))
                {
                    this.mUISimulationActionsGroup = new UISimulationActionsGroup(this);
                }
                return this.mUISimulationActionsGroup;
            }
        }
        
        public UIGatewayRequestGroup UIGatewayRequestGroup
        {
            get
            {
                if ((this.mUIGatewayRequestGroup == null))
                {
                    this.mUIGatewayRequestGroup = new UIGatewayRequestGroup(this);
                }
                return this.mUIGatewayRequestGroup;
            }
        }
        #endregion
        
        #region Fields
        private UISimulationActionsGroup mUISimulationActionsGroup;
        
        private UIGatewayRequestGroup mUIGatewayRequestGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UISimulationActionsGroup : WpfGroup
    {
        
        public UISimulationActionsGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.Name] = "Simulation Actions";
            #endregion
        }
        
        #region Properties
        public WpfButton UICheckConnectionButton
        {
            get
            {
                if ((this.mUICheckConnectionButton == null))
                {
                    this.mUICheckConnectionButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICheckConnectionButton.SearchProperties[WpfButton.PropertyNames.Name] = "Check Connection";
                    #endregion
                }
                return this.mUICheckConnectionButton;
            }
        }
        
        public WpfButton UISendButton
        {
            get
            {
                if ((this.mUISendButton == null))
                {
                    this.mUISendButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISendButton.SearchProperties[WpfButton.PropertyNames.Name] = "Send";
                    #endregion
                }
                return this.mUISendButton;
            }
        }
        
        public WpfButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WpfButton.PropertyNames.Name] = "Start";
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        
        public WpfButton UIStopButton
        {
            get
            {
                if ((this.mUIStopButton == null))
                {
                    this.mUIStopButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStopButton.SearchProperties[WpfButton.PropertyNames.Name] = "Stop";
                    #endregion
                }
                return this.mUIStopButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUICheckConnectionButton;
        
        private WpfButton mUISendButton;
        
        private WpfButton mUIStartButton;
        
        private WpfButton mUIStopButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIGatewayRequestGroup : WpfGroup
    {
        
        public UIGatewayRequestGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.Name] = "Gateway Request";
            #endregion
        }
        
        #region Properties
        public WpfButton UISendConfigurationButton
        {
            get
            {
                if ((this.mUISendConfigurationButton == null))
                {
                    this.mUISendConfigurationButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISendConfigurationButton.SearchProperties[WpfButton.PropertyNames.Name] = "Send Configuration";
                    #endregion
                }
                return this.mUISendConfigurationButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUISendConfigurationButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UISupportedDeviceListBList : WpfList
    {
        
        public UISupportedDeviceListBList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "SupportedDeviceListBox";
            #endregion
        }
        
        #region Properties
        public WpfListItem UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new WpfListItem(this);
                    #region Search Criteria
                    this.mUIItemListItem.SearchProperties[WpfListItem.PropertyNames.Instance] = "2";
                    #endregion
                }
                return this.mUIItemListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mUIItemListItem;
        #endregion
    }
}
