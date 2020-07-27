namespace ConsignmentShop
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelConsignmentDetails = new System.Windows.Forms.Label();
            this.listBoxProductList = new System.Windows.Forms.ListBox();
            this.labelProductList = new System.Windows.Forms.Label();
            this.listBoxShoppingCart = new System.Windows.Forms.ListBox();
            this.labelShoppingCart = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.listBoxVendorsList = new System.Windows.Forms.ListBox();
            this.labelVendorsList = new System.Windows.Forms.Label();
            this.labelStoreProfit = new System.Windows.Forms.Label();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelVendorProfit = new System.Windows.Forms.Label();
            this.labelPaidToVendor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelConsignmentDetails
            // 
            this.labelConsignmentDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConsignmentDetails.AutoSize = true;
            this.labelConsignmentDetails.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelConsignmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsignmentDetails.Location = new System.Drawing.Point(265, 43);
            this.labelConsignmentDetails.Name = "labelConsignmentDetails";
            this.labelConsignmentDetails.Size = new System.Drawing.Size(165, 25);
            this.labelConsignmentDetails.TabIndex = 0;
            this.labelConsignmentDetails.Text = "Consignment Info";
            this.labelConsignmentDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxProductList
            // 
            this.listBoxProductList.FormattingEnabled = true;
            this.listBoxProductList.ItemHeight = 16;
            this.listBoxProductList.Location = new System.Drawing.Point(64, 109);
            this.listBoxProductList.Name = "listBoxProductList";
            this.listBoxProductList.Size = new System.Drawing.Size(244, 132);
            this.listBoxProductList.TabIndex = 1;
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Location = new System.Drawing.Point(64, 86);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(91, 17);
            this.labelProductList.TabIndex = 2;
            this.labelProductList.Text = "Product List :";
            // 
            // listBoxShoppingCart
            // 
            this.listBoxShoppingCart.FormattingEnabled = true;
            this.listBoxShoppingCart.ItemHeight = 16;
            this.listBoxShoppingCart.Location = new System.Drawing.Point(459, 109);
            this.listBoxShoppingCart.Name = "listBoxShoppingCart";
            this.listBoxShoppingCart.Size = new System.Drawing.Size(244, 132);
            this.listBoxShoppingCart.TabIndex = 3;
            // 
            // labelShoppingCart
            // 
            this.labelShoppingCart.AutoSize = true;
            this.labelShoppingCart.Location = new System.Drawing.Point(456, 86);
            this.labelShoppingCart.Name = "labelShoppingCart";
            this.labelShoppingCart.Size = new System.Drawing.Size(106, 17);
            this.labelShoppingCart.TabIndex = 4;
            this.labelShoppingCart.Text = "Shopping Cart :";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.Location = new System.Drawing.Point(314, 158);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(130, 43);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add To Cart >>";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.Location = new System.Drawing.Point(573, 247);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(130, 43);
            this.buttonPurchase.TabIndex = 6;
            this.buttonPurchase.Text = "Purcahase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // listBoxVendorsList
            // 
            this.listBoxVendorsList.FormattingEnabled = true;
            this.listBoxVendorsList.ItemHeight = 16;
            this.listBoxVendorsList.Location = new System.Drawing.Point(64, 349);
            this.listBoxVendorsList.Name = "listBoxVendorsList";
            this.listBoxVendorsList.Size = new System.Drawing.Size(244, 132);
            this.listBoxVendorsList.TabIndex = 7;
            // 
            // labelVendorsList
            // 
            this.labelVendorsList.AutoSize = true;
            this.labelVendorsList.Location = new System.Drawing.Point(64, 329);
            this.labelVendorsList.Name = "labelVendorsList";
            this.labelVendorsList.Size = new System.Drawing.Size(95, 17);
            this.labelVendorsList.TabIndex = 8;
            this.labelVendorsList.Text = "Vendors List :";
            // 
            // labelStoreProfit
            // 
            this.labelStoreProfit.AutoSize = true;
            this.labelStoreProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreProfit.Location = new System.Drawing.Point(456, 394);
            this.labelStoreProfit.Name = "labelStoreProfit";
            this.labelStoreProfit.Size = new System.Drawing.Size(101, 17);
            this.labelStoreProfit.TabIndex = 9;
            this.labelStoreProfit.Text = "Store Profit :";
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfit.Location = new System.Drawing.Point(593, 394);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(49, 17);
            this.labelProfit.TabIndex = 10;
            this.labelProfit.Text = "$0.00";
            // 
            // labelVendorProfit
            // 
            this.labelVendorProfit.AutoSize = true;
            this.labelVendorProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendorProfit.Location = new System.Drawing.Point(593, 358);
            this.labelVendorProfit.Name = "labelVendorProfit";
            this.labelVendorProfit.Size = new System.Drawing.Size(49, 17);
            this.labelVendorProfit.TabIndex = 12;
            this.labelVendorProfit.Text = "$0.00";
            // 
            // labelPaidToVendor
            // 
            this.labelPaidToVendor.AutoSize = true;
            this.labelPaidToVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidToVendor.Location = new System.Drawing.Point(456, 358);
            this.labelPaidToVendor.Name = "labelPaidToVendor";
            this.labelPaidToVendor.Size = new System.Drawing.Size(131, 17);
            this.labelPaidToVendor.TabIndex = 11;
            this.labelPaidToVendor.Text = "Paid To Vendor :";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.labelVendorProfit);
            this.Controls.Add(this.labelPaidToVendor);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.labelStoreProfit);
            this.Controls.Add(this.labelVendorsList);
            this.Controls.Add(this.listBoxVendorsList);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.labelShoppingCart);
            this.Controls.Add(this.listBoxShoppingCart);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.listBoxProductList);
            this.Controls.Add(this.labelConsignmentDetails);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelConsignmentDetails;
        private System.Windows.Forms.ListBox listBoxProductList;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.ListBox listBoxShoppingCart;
        private System.Windows.Forms.Label labelShoppingCart;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.ListBox listBoxVendorsList;
        private System.Windows.Forms.Label labelVendorsList;
        private System.Windows.Forms.Label labelStoreProfit;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelVendorProfit;
        private System.Windows.Forms.Label labelPaidToVendor;
    }
}

