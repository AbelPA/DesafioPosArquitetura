namespace Domain.Entities.Cliente
{
    public class Pessoa
    {
        public long Id { get; private set; }

        public void AdicionarIdPessoaFisica(long id)
        {
            Id = id;
        }
    }
}
