using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentShopLibrary;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public class ConsignmentShopClass
    {
        private Store store = new Store();
        private Logger log = new Logger();
        private List<Product> shoppingCartItem = new List<Product>();
        BindingSource productBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeProfit;
        static private decimal paidToVendor;

        //Display listbox items in a formatted way
        public void DisplayToListBox(ListBox listBoxProductList, ListBox listBoxShoppingCart, ListBox listBoxVendorsList)
        {

            productBinding.DataSource = store.Products.Where(x => x.Sold == false).ToList();
            listBoxProductList.DataSource = productBinding;

            listBoxProductList.DisplayMember = "Display";
            listBoxProductList.ValueMember = "Display";


            cartBinding.DataSource = shoppingCartItem;
            listBoxShoppingCart.DataSource = cartBinding;

            listBoxShoppingCart.DisplayMember = "Display";
            listBoxShoppingCart.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            listBoxVendorsList.DataSource = vendorBinding;

            listBoxVendorsList.DisplayMember = "Display";
            listBoxVendorsList.ValueMember = "Display";
        }

        //Add Store , product and Vendors data
        public void SetUpData()
        {
            try
            {
                store.Vendors.Add(new Vendor { FirstName = "Thomas", LastName = "Warner" });
                store.Vendors.Add(new Vendor { FirstName = "David", LastName = "Moeller" });

                store.Products.Add(new Product
                {
                    Title = "SmartPhone",
                    Description = "Samsung Mobile",
                    Price = 20.90M,
                    Owner = store.Vendors[0]
                });

                store.Products.Add(new Product
                {
                    Title = "Laptop",
                    Description = "Lenovo Laptop",
                    Price = 90.90M,
                    Owner = store.Vendors[1]
                });

                store.Products.Add(new Product
                {
                    Title = "KeyBoard",
                    Description = "Dell",
                    Price = 2.90M,
                    Owner = store.Vendors[1]
                });

                store.Products.Add(new Product
                {
                    Title = "CPU",
                    Description = "Intel",
                    Price = 2.90M,
                    Owner = store.Vendors[0]
                });
            }
            catch (Exception ex)
            {
                log.LogWrite(ex.ToString());
            }
        }

        //Add selected item to the shopping cart list
        public void AddToCart(ListBox listBoxShoppingCart, ListBox listBoxProductList)
        { 
            try
            {
                Product selectedItem = (Product)listBoxProductList.SelectedItem;
                shoppingCartItem.Add(selectedItem);

                cartBinding.ResetBindings(false);

                log.LogWrite("Added product to the shopping Cart: ");
                foreach (Product item in listBoxShoppingCart.Items)
                    log.LogWrite(item.Title);
            }
            catch (Exception ex)
            {
                log.LogWrite(ex.ToString());
            }
        }

        //Mark each item in the cart as sold
        //Clear the cart once purchased and
        // calculate vendors profit store profit
        public void PurchaseProduct(Label labelProfit, Label labelVendorProfit)
        {        
            try
            {
                foreach (Product item in shoppingCartItem)
                {
                    item.Sold = true;
                    item.Owner.PaymemtDue += (decimal)item.Owner.Comission * item.Price;
                    paidToVendor = paidToVendor + item.Owner.PaymemtDue;
                    storeProfit += (1 - (decimal)item.Owner.Comission) * item.Price;
                }
                shoppingCartItem.Clear();
                productBinding.DataSource = store.Products.Where(x => x.Sold == false).ToList();

                labelProfit.Text = string.Format("${0}", storeProfit);
                labelVendorProfit.Text = string.Format("${0}", paidToVendor);

                cartBinding.ResetBindings(false);
                productBinding.ResetBindings(false);
                vendorBinding.ResetBindings(false);
            }
            catch (ArithmeticException ex)
            {
                log.LogWrite(ex.ToString());
            }
        }
    }
}