using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{

    //inicializando a coleção no construtor para evitar erros de referência nula
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }


    //por conveção o EF entende o nome Id no final ou sozinho como chave primária
    public int CategoriaId { get; set; }

    //Definindo a propriedade como nula -> ?
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }


    //relacionamento 1 para muitos (uma categoria para muitos produtos)
    // poderia ter sido feito com List<Produto>
    public ICollection<Produto>? Produtos { get; set; }


    }
