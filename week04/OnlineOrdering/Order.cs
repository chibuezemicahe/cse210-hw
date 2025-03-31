namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public float CalculateTotalCost()
        {
            float productTotal = 0;
            foreach (Product product in _products)
            {
                productTotal += product.CalculateTotalCost();
            }

            float shippingCost = _customer.IsUSACustomer() ? 5 : 35;
            return productTotal + shippingCost;
        }

        public string GeneratePackingLabel()
        {
            string label = "PACKING LABEL\n";
            foreach (Product product in _products)
            {
                label += $"{product.GetProductDetails()}\n";
            }
            return label;
        }

        public string GenerateShippingLabel()
        {
            return $"SHIPPING LABEL\nCustomer: {_customer.GetName()}\n{_customer.GetFormattedAddress()}";
        }
    }
}