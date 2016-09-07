using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinaWeb.Veterinaria.Dominio
{
    public class Prontuario
    {
        public long Id { get; set; }
        public DateTime DataDeAtendimento { get; set; }
        public string Obeservacoes { get; set; }
        
        public long IdVeterinario { get; set; }
        public long IdAnimais { get; set; }
     
        public virtual Veterinario Veterinario { get; set; }
        public virtual Animal Animal { get; set; }

        
    }
}