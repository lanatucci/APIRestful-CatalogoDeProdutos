namespace APICatalogo.Models;

public class Categoria
{
    //por conveção o EF entende o nome Id no final ou sozinho como chave primária
    public int CategoriaId { get; set; }

    //Definindo a propriedade como nula -> ?
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }


}
