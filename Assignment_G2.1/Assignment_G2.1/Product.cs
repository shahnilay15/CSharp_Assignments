namespace Assignment_G2._1
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;
        private string type;

        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
