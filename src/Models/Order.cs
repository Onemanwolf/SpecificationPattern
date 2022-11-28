namespace src.Models
{
    public class Order
    {
        public string? OrderId { get; set; }
        public string? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public double OrderTotal { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}