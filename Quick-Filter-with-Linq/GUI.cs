using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quick_Filter_with_Linq
{
    public partial class Gui : Form
    {
        public delegate void Delegate(object sender, EventArgs e);

        public Delegate Delegem;

        public NorthwindDB Db = new NorthwindDB();
        public IList<Product> Products;
        
        public Gui()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            FirstRun();
        }

        private void FirstRun()
        {
            Db.Products.ToListViewItems(lstProducts);
            txtProductName.AutoCompleteCustomSource = (from p in Db.Products
                                                       select p.ProductName).ToAutoCompleteStringCollection();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            var delegem = new Delegate(Filter);
            delegem.Invoke(sender, e);
        }

        public void Filter(object sender, EventArgs e)
        {
            (from p in Db.Products
                                where p.ProductName.Contains(txtProductName.Text)
                                select p).ToList().ToListViewItems(lstProducts);
        }
    }
}
