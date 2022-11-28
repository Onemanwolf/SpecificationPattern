using System.Linq.Expressions;
using src.Models;

namespace src.Specifications
{
    internal class AndSpecification : ISpecification<Order>
    {
        private OrderSpecification _orderSpecification;
        private ISpecification<Order> _orderItemSpecification;

        public AndSpecification(OrderSpecification orderSpecification, ISpecification<Order> orderItemSpecification)
        {
            _orderSpecification = orderSpecification;
            _orderItemSpecification = orderItemSpecification;
        }

        public bool IsSatisfiedBy(Order candidate)
        {
           var isStatisfied = ToExpression().Compile();
           return  isStatisfied(candidate);


        }

        public Expression<Func<Order, bool>> ToExpression()
        {
            return order => order.OrderItems.Count > 0;
        }
    }
}