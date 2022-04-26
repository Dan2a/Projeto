using System.Text.Json.Serialization;

namespace Projeto.Models.Dtos
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Setores> Setores { get; set; }
    }
}
