using System.Linq.Expressions;

namespace src.Specifications
{
    public interface ISpecification<T>
    {
         bool IsSatisfiedBy(T candidate);
         Expression<Func<T, bool>> ToExpression();

    }
}