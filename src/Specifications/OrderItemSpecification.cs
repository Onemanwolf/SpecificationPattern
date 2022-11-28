using System.Linq.Expressions;
using src.Models;

namespace src.Specifications
{
    public class OrderItemSpecification : ISpecification<Order>
    {


        public bool IsSatisfiedBy(Order candidate)
        {
            return candidate.OrderItems.Count > 0;
             var result =   ToExpression().Compile();
            return result(candidate);
        }

        public Expression<Func<Order, bool>> ToExpression()
        {
            return order => order.OrderItems.Count > 0;
        }


    }

}