using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;


// Atributo Data Annotations para definir tabela. Redundante pois já foi definido no arquivo de contexto
[Table("Categorias")]
public class Categoria
{
   
    //inicializando a coleção no construtor para evitar erros de referência nula
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    //Atributo Data Annotations para definir chave primária (TAMBÉM REDUNDANTE POR CONTA DO ID)
    [Key]
    //por conveção o EF entende o nome Id no final ou sozinho como chave primária
    public int CategoriaId { get; set; }

    
    [Required] //Atributo Data Annotations para definir que o campo é obrigatório
    [StringLength(80)] //definindo tamanho máximo do campo com Data Annotations
    //Definindo a propriedade como nula -> ?
    public string? Nome { get; set; }

    [Required] 
    [StringLength(300)]
    public string? ImagemUrl { get; set; }


    //relacionamento 1 para muitos (uma categoria para muitos produtos)
    // poderia ter sido feito com List<Produto>
    public ICollection<Produto>? Produtos { get; set; }


    }
