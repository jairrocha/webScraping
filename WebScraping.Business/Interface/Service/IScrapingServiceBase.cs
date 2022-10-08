using System.Collections.Generic;
using WebScraping.Domain.Entity;

namespace WebScraping.Domain.Interface.Service
{
    public interface IScrapingServiceBase<TEntity> where TEntity : EntityBase
    {
        IEnumerable<TEntity> Get(Dictionary<string, string> parametros);
    }
}
