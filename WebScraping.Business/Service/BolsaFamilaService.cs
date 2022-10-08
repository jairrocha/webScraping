using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Business.Entity;
using WebScraping.Business.Interface.Service;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Business.Service
{
    public class BolsaFamilaService : ScrapingServiceBase<BolsaFamilia>, IScrapingBolsaFamiliaService
    {
        public BolsaFamilaService() : base("https://www.portaltransparencia.gov.br/download-de-dados/bolsa-familia-pagamentos/")
        {
        }

        public override IEnumerable<BolsaFamilia> Get(Dictionary<string, string> parametros)
        {


            FazDownload($"{_url}{parametros["anomes"]}", parametros["anomes"]);

            return null;
        }

   
    }
}
