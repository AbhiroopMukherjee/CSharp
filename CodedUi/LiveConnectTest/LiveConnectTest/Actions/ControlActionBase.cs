namespace LiveConnectTest.Actions
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System.Drawing;
    using System.Threading;

    internal abstract class ControlActionBase
    {
        protected void Click(WinButton winButton)
        {
            if (winButton != null && winButton.WaitForControlExist())
            {
                Mouse.Click(new Point(winButton.BoundingRectangle.Location.X + 90, winButton.BoundingRectangle.Location.Y + 10));
                Thread.Sleep(1000);
            }
        }
    }
}
