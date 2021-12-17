namespace AdocaoAnimaisApi.Domain.DTO
{
    public class AdocaoResponse
    {

        public int IdAdocao { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdEspecie { get; set; }
        public DateTime? DataNascimento { get; set; }
        public byte NivelFofura { get; set; }
        public byte NivelCarinho { get; set; }
        public string Email { get; set; } = null!;
        public string? Imagem { get; set; }

        public EspecieResponse Especie { get; set; }

    }
}
