using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Chapter8_Demo
{
    public class MyTableViewDataSource : UITableViewSource
    {
        private const string CellIdentifier = "datacell";
        private List<string> _restaurantNames = new List<string>
            {
                "Cafe Deadend", "Homei", "Teakha", "Cafe Loisl", "Petite Oyster",
                "For Kee Restaurant", "Po's Atelier", "Bourke Street Bakery", "Haigh's Chocolate",
                 "Palomino Espresso", "Upstate", "Traif", "Graham Avenue Meats",
                 "Waffle & Wolf", "Five Leaves", "Cafe Lore", "Confessional", "Barrafina", "Donostia",
                 "Royal Oak", "CASK Pub and Kitchen"
            };
       
        public MyTableViewDataSource()
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier);
            cell.TextLabel.Text = _restaurantNames[indexPath.Row];
            cell.ImageView.Image = UIImage.FromBundle(_restaurantNames[indexPath.Row]);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _restaurantNames.Count;
        }
    }
}
