//class Conta
//{
// public string Titular { get; set; }
// public int Saldo { get; set; }

// public void ExibirFichaTecnica()
//  {
//     Console.WriteLine($"Titular: {Titular}");
//     Console.WriteLine($"Saldo: {Saldo}");

// }
//}


//Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço
//e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto,
//para que seja usado pela equipe de vendas.

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public int Preco { get; set; }
    public bool Estoque { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Estoque: {Estoque}");
    }
}

