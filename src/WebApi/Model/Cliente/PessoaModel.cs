namespace WebApi.Model.Cliente
{
    public class PessoaModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
