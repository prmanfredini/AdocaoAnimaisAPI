using System;
using System.Collections.Generic;

namespace AdocaoAnimaisApi.Domain.Entity
{
    public partial class Adocao
    {
        public int IdAdocao { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdEspecie { get; set; }
        public DateTime? DataNascimento { get; set; }
        public byte NivelFofura { get; set; }
        public byte NivelCarinho { get; set; }
        public string Email { get; set; } = null!;
        public string? Imagem { get; set; }

        public virtual Especie? IdEspecieNavigation { get; set; }
    }
}
