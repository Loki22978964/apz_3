using BLL.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Strategies
{
    public class NameOnlySearchStrategy : ISearchStrategy
    {
        public Expression<Func<ContentItem, bool>> GetSearchExpression(string query)
        {
            return c => c.Name.Contains(query);
        }
    }
}
