namespace Lica_Games.Models;

public class Jogos
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public List<string> Genero { get; set; } = [];

    public string Descricao { get; set; }

    public string Desenvolvedora { get; set; }

    public string Imagem { get; set; }
}
