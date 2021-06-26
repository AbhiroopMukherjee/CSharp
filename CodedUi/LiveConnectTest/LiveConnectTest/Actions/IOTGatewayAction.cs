namespace LiveConnectTest.Actions
{
    using LiveConnectTest.Controls;
    using LiveConnectTest.Utils;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using System.Linq;
    using System;
    using System.Diagnostics;

    internal class IotGatewayAction : ControlActionBase
    {
        private readonly IotGatewayControl _iotGatewayControl;

        public IotGatewayAction()
        {
            this._iotGatewayControl = new IotGatewayControl();
        }

        internal void ClickOnWinSearchButton()
        {
            this.Click(this._iotGatewayControl.WindowsSearchButton);
            Thread.Sleep(2000);
        }

        internal void EnterBuildLocation()
        {
            SendKeys.SendWait(CommonConstants.IotGatewayBuildLocation);
        }

        internal void ClickOnDateModifiedButton()
        {
            if(SortDateInDescendingOrder())
                this.Click(this._iotGatewayControl.DateModifiedButton);
        }

        private bool SortDateInDescendingOrder()
        {
            try
            {
                bool isFolderSortedAccordingToDateModifiedDesc = false;
                var itemsInIotGatewayFolderList = this._iotGatewayControl.IOTGatewayFolderListView.Items.ToArray();
                for (int i = 0; i < itemsInIotGatewayFolderList.Length; i++)
                {
                    string nameOfItem = itemsInIotGatewayFolderList[i].Name ?? throw new ArgumentNullException(
                                            $"itemsInIotGatewayFolderList[i].Name");
                    string nameOfNextItem = itemsInIotGatewayFolderList[i + 1].Name;
                    if (!nameOfItem.StartsWith(CommonConstants.FolderNameInBuildLocation))
                    {
                        int nameOfItemValue = Convert.ToInt32(nameOfItem.Replace(".", ""));
                        int nameOfNextItemValue = Convert.ToInt32(nameOfNextItem.Replace(".", ""));
                        if (nameOfNextItemValue > nameOfItemValue)
                        {
                            isFolderSortedAccordingToDateModifiedDesc = true;
                        }
                        else
                        {
                            string fullFolderPath = CommonConstants.IotGatewayBuildLocation + "\\" + nameOfItem;
                            GetTheFullPathForIotGatewayMsi(fullFolderPath);
                            break;
                        }
                    }
                }
                return isFolderSortedAccordingToDateModifiedDesc;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void GetTheFullPathForIotGatewayMsi(string latestFolderPath)
        {
            DirectoryInfo directory =
                new DirectoryInfo(latestFolderPath);
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (var chilDirectory in directories)
            {
                FileInfo[] file = chilDirectory.GetFiles();
                if (file.Length > 1)
                {
                    var fileName = file[0].Name;
                    if (fileName.EndsWith(CommonConstants.FileEndingPatternInIotGatewayLocation) && Environment.Is64BitOperatingSystem)
                    {
                        latestFolderPath = latestFolderPath + "\\" + CommonConstants.FolderName + "\\" + fileName;
                        InstallIotGateway(latestFolderPath);
                        break;
                    }
                    else
                    {
                        fileName = file[1].DirectoryName;
                        latestFolderPath = latestFolderPath + "\\" + CommonConstants.FolderName + "\\" + fileName;
                        InstallIotGateway(latestFolderPath);
                    }
                }
                
            }
            Console.WriteLine(latestFolderPath);
        }

        private void InstallIotGateway(string installerPath)
        {
            Process installerProcess = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = @"/i " + installerPath + " /q";
            processStartInfo.FileName = "msiexec";
            installerProcess.StartInfo = processStartInfo;
            installerProcess.Start();
            while (!installerProcess.HasExited)
            {
                Application.DoEvents();
                Thread.Sleep(250);
            }

            MessageBox.Show(CommonConstants.MessageBoxInformation, CommonConstants.MessageBoxCaption, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            installerProcess.WaitForExit();
        }
    }
}
