using Foundation;
using System;
using UIKit;

namespace HelloWorld
{
    public partial class TestViewController : UIViewController
    {
        public TestViewController (IntPtr handle) : base (handle){
            MyButton.SetTitle("Ceva", UIControlState.Normal);
        }
    }
}