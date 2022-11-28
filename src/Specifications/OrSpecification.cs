using src.Models;

namespace src.Specifications
{
    public class OrSpecification
    {
        private ISpecification<Order> _orderSpecification;
        private ISpecification<Order> _orderItemSpecification;

        public OrSpecification(ISpecification<Order> orderSpec, ISpecification<Order> orderItemSpec)
        {
            _orderSpecification = orderSpec;
            _orderItemSpecification = orderItemSpec;
        }

        public bool IsSatisfiedBy(Order candidate)
        {
            return _orderSpecification.IsSatisfiedBy(candidate) || _orderItemSpecification.IsSatisfiedBy(candidate);
        }
    }
}