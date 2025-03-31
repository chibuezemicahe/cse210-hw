namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsUSACustomer()
        {
            return _address.IsUSA();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetFormattedAddress()
        {
            return _address.FormatAddress();
        }
    }
}