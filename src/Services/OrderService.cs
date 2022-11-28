using src.Models;
using src.Specifications;

namespace src.Services
{
    public class OrderService
    {
        public ISpecification<Order> _specification { get; set; }
        public OrderService(ISpecification<Order> specification)
        {
            _specification = specification;
        }



        public Order CreateOrder(Order order)
        {
            _specification.IsSatisfiedBy(order);
            return order;
        }
    }
}