using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Business.Service
{
    public abstract class ScrapingServiceBase<TEntity> : IScrapingServiceBase<TEntity> where TEntity : EntityBase
    {
        protected readonly string _url;

        protected ScrapingServiceBase(string url)
        {
            _url = url;
        }

        public abstract IEnumerable<TEntity> Get(Dictionary<string, string> parametros);

        protected virtual HtmlDocument FazRequisicao(string url)
        {

            var wc = new WebClient();
            string pagina = wc.DownloadString(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(pagina);

            return htmlDocument;

        }

        protected virtual void FazDownload (string url, string nomeArquivo)
        {

            try
            {
                var wc = new WebClient();
                wc.DownloadFile(url, $"{nomeArquivo}.zip");
            }
            catch (Exception ex)
            {

                throw ex;
            }

         

        }


    }
}
