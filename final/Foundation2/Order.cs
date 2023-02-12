class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        public Customer Customer
        {
            get { return customer; }
        }

        public List<Product> Products
        {
            get { return products; }
        }

        public double TotalCost
        {
            get
            {
                double totalPrice = 0;
                foreach (Product product in products)
                {
                    totalPrice += product.TotalPrice;
                }

                return totalPrice + (customer.LivesInUSA() ? 5 : 35);
                }
}
 public string PackingLabel
    {
        get
        {
            string label = "";
            foreach (Product product in products)
            {
                label += string.Format("{0} (Product ID: {1})\n", product.Name, product.ProductId);
            }

            return label;
        }
    }

    public string ShippingLabel
    {
        get
        {
            return string.Format("{0}\n{1}", customer.Name, customer.Address.ToString());
        }
    }
}
