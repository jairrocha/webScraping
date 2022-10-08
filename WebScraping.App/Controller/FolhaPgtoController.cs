using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Controller
{
    public class FolhaPgtoController
    {
        private readonly IScrapingFolhaPgtoService _folhaPgtoService;


        public FolhaPgtoController(IScrapingFolhaPgtoService folhaPgtoService)
        {
            _folhaPgtoService = folhaPgtoService;
        }

        public async Task<IEnumerable<FolhaPgtoBarauna>> BuscarFolhaPgto(Dictionary<string, string> parametros)
        {

            var tasks = new List<Task<IEnumerable<FolhaPgtoBarauna>>>();
            var dados = new List<FolhaPgtoBarauna>();



            if (parametros["acumulado"] == "1")
            {


                for (DateTime dataRef = DateTime.Today.AddMonths(-12); dataRef < DateTime.Today; dataRef.AddMonths(1))
                {

                    var p = new Dictionary<string, string>();
                    p["mes"] = dataRef.Month.ToString("d2");
                    p["ano"] = dataRef.Year.ToString();
                    dataRef = dataRef.AddMonths(1);

                    var task = Task.Factory.StartNew(() =>
                    {
                        return _folhaPgtoService.Get(p);
                    });

                    tasks.Add(task);
                }

            }
            else
            {

                tasks.Add(Task.Factory.StartNew(() =>
                {

                    var resultado = _folhaPgtoService.Get(parametros);

                    return resultado;

                }));

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
