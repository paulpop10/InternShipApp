// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloWorld
{
    [Register ("TestViewController")]
    partial class TestViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AngelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView background { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CatButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CookieButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoveButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AngelButton != null) {
                AngelButton.Dispose ();
                AngelButton = null;
            }

            if (background != null) {
                background.Dispose ();
                background = null;
            }

            if (CatButton != null) {
                CatButton.Dispose ();
                CatButton = null;
            }

            if (CookieButton != null) {
                CookieButton.Dispose ();
                CookieButton = null;
            }

            if (LoveButton != null) {
                LoveButton.Dispose ();
                LoveButton = null;
            }
        }
    }
}