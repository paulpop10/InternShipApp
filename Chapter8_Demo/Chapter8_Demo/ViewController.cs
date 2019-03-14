using System;
using System.Collections.Generic;

using UIKit;

namespace Chapter8_Demo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //// Perform any additional setup after loading the view, typically from a nib.

           RestaurantTableView.Source = new MyTableViewDataSource();
        }

        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}
