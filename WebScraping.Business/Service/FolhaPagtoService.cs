using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebScraping.Domain.Entity;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.Business.Service
{


    public class FolhaPagtoService :ScrapingServiceBase<FolhaPgtoBarauna>, IScrapingFolhaPgtoService
    {

        public FolhaPagtoService() : base("https://transparencia.elmartecnologia.com.br/")
        {
            
        }

        public override IEnumerable<FolhaPgtoBarauna> Get(Dictionary<string, string> parametros)
        {
            string url = _url + $"Export/Data?ecode=201021&ctx=201021&showResult=False&module=FolhaPagModule"
                    + $"&returnType=json&competencia%24State=%7B%26quot%3BrawValue%26quot%3B%3A%26quot%3B07%2F2022"
                    + $"%26quot%3B%2C%26quot%3BvalidationState%26quot%3B%3A%26quot%3B%26quot%3B%7D&competencia={parametros["mes"]}%2F{parametros["ano"]}&"
                    + "exercicio%24State=%7B%26quot%3BrawValue%26quot%3B%3A%26quot%3B2022%26quot%3B%2C%26quot%3BvalidationState"
                    + $"%26quot%3B%3A%26quot%3B%26quot%3B%7D&exercicio={parametros["ano"]}&DXScript=&showUrl=True&DXCss=&DXMVCEditorsValues="
                    + $"%7B%22competencia%22%3A%2207%2F2022%22%2C%22exercicio%22%3A%222022%22%7D";

            var document = FazRequisicao(url);
            url = document.GetElementbyId("URLIntegra").InnerText.Replace("amp;", "");
            document = FazRequisicao(url);



            var json = WebUtility.HtmlDecode(document.Text);
            json = Regex.Replace(json, "(?:<style.+?>.+?</style>|<script.+?>.+?</script>|<(?:!|/?[a-zA-Z]+).*?/?>)|/s+", "");
            json = json.Substring(json.IndexOf("[{") - 1, json.Length - json.IndexOf("[{") - 1);
            json = json.Trim();

            var list = JsonConvert.DeserializeObject<List<FolhaPgtoBarauna>>(json);

            return  list;

        }


    }
}
