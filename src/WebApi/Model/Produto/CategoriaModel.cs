namespace WebApi.Model.Produto
{
    public class CategoriaModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoModel> Produtos { get; private set; }
    }
}
