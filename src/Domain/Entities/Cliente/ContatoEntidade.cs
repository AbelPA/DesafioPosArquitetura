namespace Domain.Entities.Cliente
{
    public class ContatoEntidade
    {
        public long Id { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public ContatoEntidade(long id, string telefone, string email)
        {
            Id = id;
            Telefone = telefone;
            Email = email;
        }
    }
}
