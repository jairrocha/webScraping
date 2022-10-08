using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping.Domain.Entity
{
    public class Msdn : EntityBase
    {
        public string Titulo { get; set; }
        public string Link { get; set; }
        public string Respostas { get; set; }
        public string Exibicoes { get; set; }
        public string CriadoPor { get; set; }
        
    }
}
