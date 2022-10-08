using Newtonsoft.Json;

namespace WebScraping.Domain.Entity
{
    public class FolhaPgtoBarauna : EntityBase
    {
        [JsonProperty("Competência")]
        public string Competencia { get; set; }

        [JsonProperty("Matrícula")]
        public string Matricula { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("CPF")]
        public string CPF { get; set; }

        [JsonProperty("Cargo")]
        public string Cargo { get; set; }

        [JsonProperty("Secretaria")]
        public string Secretaria { get; set; }

        [JsonProperty("Regime")]
        public string Regime { get; set; }

        [JsonProperty("Dt. Admissão")]
        public string DtAdmissao { get; set; }

        [JsonProperty("Vantagens")]
        public string Vantagens { get; set; }

        [JsonProperty("Descontos")]
        public string Descontos { get; set; }

        [JsonProperty("Líquido")]
        public string Liquido { get; set; }

        [JsonProperty("cpt")]
        public string cpt { get; set; }

    }
}
