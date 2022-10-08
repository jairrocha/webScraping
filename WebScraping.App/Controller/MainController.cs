using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Controller
{
    public class MainController
    {
        private readonly IScrapingMsdnService _scrapingMsdnService;
        private readonly IScrapingFolhaPgtoService _scrapingFolhaPgtoService;

        public MainController(ServiceProvider serviceProvider)
        {
            _scrapingMsdnService = 
                serviceProvider.GetRequiredService<IScrapingMsdnService>();
            
            _scrapingFolhaPgtoService = 
                serviceProvider.GetRequiredService<IScrapingFolhaPgtoService>();
        }


        public IEnumerable<FolhaPgtoBarauna> BuscarFolhaPgto(Dictionary<string, string> parametros)
        {
            return _scrapingFolhaPgtoService.Get(parametros);
        }

        public IEnumerable<Msdn> BuscarPostMsdn(Dictionary<string, string> parametros)
        {
            return _scrapingMsdnService.Get(parametros);
        }


    }
}
