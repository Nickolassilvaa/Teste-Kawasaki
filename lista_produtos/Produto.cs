namespace lista_produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string ProdutoId { get; set; } = string.Empty;
        public string ProdutoDescricao { get; set; } = string.Empty;
        public decimal ProdutoPreco { get; set; }
    }
}
