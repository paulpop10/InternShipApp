using System;
using System.Collections.Generic;
using UIKit;

namespace HelloWorld
{
    public partial class TestViewController : UIViewController
    {
        public TestViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AngelButton.TouchUpInside += ShowMessage;
            LoveButton.TouchUpInside += ShowMessage;
            CatButton.TouchUpInside += ShowMessage;
            CookieButton.TouchUpInside += ShowMessage;
        }

        public void ShowMessage(object sender, EventArgs e)
        {
            var emojiDictionary = new Dictionary<string, string>
            {
                ["\ud83d\ude07"] = "Angel",
                ["\ud83d\ude0d"] = "Love",
                ["\ud83d\ude38"] = "Cat",
                ["\ud83c\udf6a"] = "Cookie",
            };

            var tappedButton = sender as UIButton;
            var wordToLookup = tappedButton.TitleLabel.Text;
            var alertController = UIAlertController.Create("Meaning", emojiDictionary[wordToLookup], UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alertController, true, null);
        }
    }
}
