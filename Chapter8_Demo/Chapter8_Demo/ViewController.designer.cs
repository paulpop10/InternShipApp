// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Chapter8_Demo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView RestaurantTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (RestaurantTableView != null) {
                RestaurantTableView.Dispose ();
                RestaurantTableView = null;
            }
        }
    }
}