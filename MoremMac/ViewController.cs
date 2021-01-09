using System;

using AppKit;
using Foundation;

namespace MoremMac
{
    public partial class ViewController : NSViewController
    {
        private bool Connection = false;
        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ConnectionLabel.StringValue = "Disconnected";
        }

        //User clicked the Connect Button
        partial void ClickedConnect(NSObject sender)
        {
            Connection = true;
            ConnectionLabel.StringValue = "Connected";
        }

        //User clicked the Disconnect Button
        partial void ClickedDisconnect(NSObject sender)
        {
            Connection = false;
            ConnectionLabel.StringValue = "Disconnected";
        }

        //User clicked the Exit Button
        partial void ClickedExit(NSObject sender)
        {
            NSApplication.SharedApplication.Terminate(sender);
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
