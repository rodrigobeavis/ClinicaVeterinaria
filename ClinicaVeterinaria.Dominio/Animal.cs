using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinaWeb.Veterinaria.Dominio
{
    public class Animal
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Raca { get; set; }
        public string NomeDoDono { get; set; }

    }
}