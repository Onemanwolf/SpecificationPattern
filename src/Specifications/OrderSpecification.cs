using System.Linq.Expressions;
using src.Models;

namespace src.Specifications
{
    public class OrderSpecification : ISpecification<Order>
    {
        public Order? Order { get; set; }
        private readonly ISpecification<Order> _orderItemSpecification;
        private readonly ISpecification<Order> _orderSpec;
        public OrderSpecification(ISpecification<Order> orderItemSpecification)

        {
            _orderItemSpecification = orderItemSpecification;

        }



        public bool and(ISpecification<Order> orderSpecification, ISpecification<Order> orderItemSpecification)

        {
           var and = new AndSpecification(this, _orderItemSpecification);
           return and.IsSatisfiedBy(Order);
        }

        public bool IsSatisfiedBy(Order candidate)
        {

           var result = ToExpression().Compile();

     
           return result(candidate);


        }

        public bool not()
        {
            return false;
        }

        public Expression<Func<Order, bool>> ToExpression()
        {
            return order => order.OrderItems.Count > 0;
        }

        public bool or(ISpecification<Order> other)
        {
            new OrSpecification(this, other);
            other.IsSatisfiedBy(Order);
            return true;
        }
    }
}