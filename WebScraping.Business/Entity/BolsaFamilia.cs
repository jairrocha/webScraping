using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.Domain.Entity;

namespace WebScraping.Business.Entity
{
    public class BolsaFamilia:EntityBase
    {
        //MÊS REFERÊNCIA
        public int mesRef { get; set; }
        //MÊS COMPETÊNCIA
        public int MesCopetencia { get; set; }
        //UF
        public string Uf { get; set; }
        //CÓDIGO MUNICÍPIO SIAFI
        public int CodigoMunicipio { get; set; }
        //NOME MUNICÍPIO
        public string NomeMunicipio { get; set; }

        //CPF FAVORECIDO
        public string Cpf { get; set; }

        //NIS FAVORECIDO
        public int Nis { get; set; }

        //NOME FAVORECIDO
        public string NomeFavorecido { get; set; }

        //VALOR PARCELA
        public decimal ValorParce { get; set; }
    }
}
