using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Business.Service
{
    public class MsdnService : ScrapingServiceBase<Msdn>, IScrapingMsdnService
    {
        public MsdnService() : base("https://social.msdn.microsoft.com/Forums/pt-br/")
        {
        }

        public override IEnumerable<Msdn> Get(Dictionary<string, string> parametros)
        {
            string titulo = String.Empty;
            string respostas = String.Empty;
            string exibicoes = String.Empty;
            string criadoPor = String.Empty;
            string link = String.Empty;
            string id = String.Empty;

       
            var document = FazRequisicao($"{_url}home/?sort=lastpostdesc&brandIgnore=true&page={parametros["pagina"]}");
            var posts = new List<Msdn>();



            foreach (HtmlNode node in document.GetElementbyId("threadList").ChildNodes)
            {
                if (node.Attributes.Count > 0)
                {
                    id = node.Attributes["data-threadid"].Value;
                    link = _url + id;
                    titulo = node.Descendants().FirstOrDefault(x => x.Id.Equals($"threadTitle_{id}")).InnerText;
                    respostas = node.Descendants().FirstOrDefault(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText;
                    exibicoes = node.Descendants().FirstOrDefault(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText;
                    criadoPor = node.Descendants().FirstOrDefault(x => x.Id.Contains("threadCreatedByUser")).InnerText;


                    posts.Add(new Msdn
                    {
                        Titulo = Encoding.UTF8.GetString(Encoding.Default
                                        .GetBytes(WebUtility.HtmlDecode(titulo))),
                        
                        Respostas = WebUtility.HtmlDecode(respostas),
                        Exibicoes = WebUtility.HtmlDecode(exibicoes),
                        CriadoPor = WebUtility.HtmlDecode(criadoPor),
                        Link = link

                    });
                }

            }

            return posts;
        }
    }
}
