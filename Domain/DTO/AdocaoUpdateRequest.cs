namespace AdocaoAnimaisApi.Domain.DTO
{
    public class AdocaoUpdateRequest
    {
        public byte NivelFofura { get; set; }
        public byte NivelCarinho { get; set; }
        public string Email { get; set; } = null!;
    }
}
