using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Quick_Filter_with_Linq
{
    public static class ListViewExtensions
    {

        public static ListViewItem ToListViewItem(this Product product)
        {
            var item = new ListViewItem(product.ProductID.ToString())
            {
                Tag = product
            };
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.QuantityPerUnit);
            return item;
        }

        public static void ToListViewItems(this IList<Product> products, ListView listview)
        {
            listview.View = View.Details;
            listview.GridLines = true;
            listview.FullRowSelect = true;

            var items = new ListView.ListViewItemCollection(listview);
            if (listview.Columns.Count == 0)
            {
                listview.Columns.Clear();
                listview.Columns.Add("ID");
                listview.Columns.Add("Product Name");
                listview.Columns.Add("Quantity Per Unit");
            }
            listview.Items.Clear();
            foreach (var product in products)
            {
                items.Add(product.ToListViewItem());
            }
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
  
        }

        public static void ToListViewItems(this DbSet<Product> products, ListView listview)
        {
            products.ToList().ToListViewItems(listview);
        }

    }
}
