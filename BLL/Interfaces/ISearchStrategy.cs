using DAL.Entities;
using System.Linq.Expressions;

namespace BLL.Interfaces
{
    public interface ISearchStrategy
    {
        Expression<Func<ContentItem, bool>> GetSearchExpression(string query);
    }
}
