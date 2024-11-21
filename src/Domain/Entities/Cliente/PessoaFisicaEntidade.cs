namespace Domain.Entities.Cliente
{
    public class PessoaFisicaEntidade : Pessoa
    {
        public string Nome { get; private set; }
        public EnderecoEntidade Endereco { get; private set; }
        public ContatoEntidade Contato { get; private set; }
        public DateOnly DataNascimento { get; private set; }

        public PessoaFisicaEntidade(string nome, EnderecoEntidade endereco, ContatoEntidade contrato, DateOnly dataNascimento) : base()
        {
            Nome = nome;
            Endereco = endereco;
            Contato = contrato;
            DataNascimento = dataNascimento;
        }
    }
}
