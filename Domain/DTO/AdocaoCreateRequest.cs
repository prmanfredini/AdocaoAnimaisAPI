using System.ComponentModel.DataAnnotations;

namespace AdocaoAnimaisApi.Domain.DTO
{
    public class AdocaoCreateRequest
    {

		[Required(AllowEmptyStrings = false, ErrorMessage = "O nome do animal é obrigatório!")]
		public string Nome { get; set; }

		public int IdEspecie { get; set; }

		public DateTime? DataNascimento { get; set; }

		public byte NivelFofura { get; set; }

		public byte NivelCarinho { get; set; }

		public string Email { get; set; } = null!;

		public string? Imagem { get; set; }

	}
}
