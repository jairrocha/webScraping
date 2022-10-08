using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Controller
{
    public class ForumController
    {
        private readonly IScrapingMsdnService _scrapingMsdnService;


        public ForumController(IScrapingMsdnService scrapingMsdnService)
        {
            _scrapingMsdnService = scrapingMsdnService;
        }

        public async Task<IEnumerable<Msdn>> BuscarPostsForum(Dictionary<string, string> parametros)
        {

            var tasks = new List<Task<IEnumerable<Msdn>>>();
            var dados = new List<Msdn>();

            int qntdePagina = int.Parse(parametros["QntdePaginas"]);


            for (int pagina =1; pagina <= qntdePagina; pagina++)
            {

                var p = new Dictionary<string, string>();

            
                p.Add("pagina", pagina.ToString());

                var task = Task.Factory.StartNew(() =>
                {
                    return _scrapingMsdnService.Get(p);
                });

                tasks.Add(task);
            }


            await Task.WhenAll(tasks);

            foreach (var task in tasks)
            {
                foreach (var item in task.Result)
                {
                    dados.Add(item);
                }
            }

            return dados;
            

        }
    }
}
