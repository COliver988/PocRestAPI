namespace PocRestAPI.Models
{
    public class Order
    {
        public Order() { }
        /// <summary>
        /// create an order from a JSON payload
        /// </summary>
        /// <param name="jsonOrder"></param>
        /// <note>no logic but returning true for tests</note>
        public Order(JsonOrder jsonOrder)
        {
            isValid = true;
        }

        public bool isValid;
        public int orderId;
    }
}
