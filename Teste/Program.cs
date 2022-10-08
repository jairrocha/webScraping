using System;
using System.Collections.Generic;
using WebScraping.Business.Service;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BolsaFamilaService();

            var p = new Dictionary<string, string>();

            p.Add("anomes", "202111");

            b.Get(p);

        }
    }
}
