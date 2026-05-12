using BLL.Interfaces;
using DAL.Entities;
using System.Linq.Expressions;

namespace BLL.Strategies
{
    public class FullSearchStrategy : ISearchStrategy
    {
        public Expression<Func<ContentItem, bool>> GetSearchExpression(string query)
        {
            return c => c.Name.Contains(query) || c.Description.Contains(query);
        }
    }
}
