
namespace Projeto.Models
{
    public class Colaboradores
    {
        public int  Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Email { get; set; }
        public virtual Setores Setor { get; set; }

    }
}
