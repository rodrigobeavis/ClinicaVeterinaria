using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinaWeb.Veterinaria.Dominio
{
    public class Veterinario
    {
        public long Id { get; set; }
        public string Especialidade { get; set; }
        public string CRV { get; set; }
    }
}