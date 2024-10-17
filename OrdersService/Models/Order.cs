namespace OrdersService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<int> ProductIds { get; set; } = new();
    }
}
