namespace OnlineBookStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
