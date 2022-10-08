using Microsoft.Extensions.DependencyInjection;
using WebScraping.Business.Service;
using WebScraping.Domain.Interface.Service;


namespace WebScraping
{
    public static class Startup
    {

        public static ServiceProvider ProvedorServico(this IServiceCollection svcCollection)
        {
            
            svcCollection.AddScoped<IScrapingFolhaPgtoService, FolhaPagtoService>();
            svcCollection.AddScoped<IScrapingMsdnService, MsdnService>();
            
            return svcCollection.BuildServiceProvider();

        }
    }
}
