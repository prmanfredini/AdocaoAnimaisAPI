using System;
using System.Collections.Generic;

namespace AdocaoAnimaisApi.Domain.Entity
{
    public partial class Especie
    {
        public Especie()
        {
            Adocoes = new HashSet<Adocao>();
        }

        public int IdEspecie { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<Adocao> Adocoes { get; set; }
    }
}
