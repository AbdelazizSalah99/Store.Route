using Domain.Models;

namespace Services.Specifications
{
    public interface ISpecification<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
    }
}