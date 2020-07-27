using System;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private ConsignmentShopClass conshopObj = new ConsignmentShopClass();
        public ConsignmentShop()
        {
            InitializeComponent();
            conshopObj.SetUpData();
            conshopObj.DisplayToListBox(listBoxProductList, listBoxShoppingCart, listBoxVendorsList);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            conshopObj.AddToCart(listBoxShoppingCart, listBoxProductList);
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            conshopObj.PurchaseProduct(labelProfit, labelVendorProfit);
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {
            LoginForm logObj = new LoginForm();
            logObj.Close();
        }
    }
}
