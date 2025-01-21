namespace oprec1
{
    public class Order
    {
        public string Customer_name { get; set; }
        public string Product_name { get; set; }
        public int Quantity { get; set; }
        public int Total_price { get; set; }
        public string Order_date { get; set; }
        public string Shipping_address { get; set; }
        public string Status { get; set; }

        public Order(string customer_name, string product_name, int quantity, int total_price, string order_date, string shipping_address, string status)
        {
            Customer_name = customer_name;
            Product_name = product_name;
            Quantity = quantity;
            Total_price = total_price;
            Order_date = order_date;
            Shipping_address = shipping_address;
            Status = status;
        }
    }
}
