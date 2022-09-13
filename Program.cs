// See https://aka.ms/new-console-template for more information
namespace blusa{

    class Program {

    public static void Main (string[] args) {
    Console.WriteLine("Olá");
    blusa b = new blusa();
    Console.WriteLine("Digite A Marca Da Blusa: ");
    b.marca = (Console.ReadLine());
    Console.WriteLine("Digite O Tamanho Da Blusa: ");
    b.tamanho = (Console.ReadLine());
    Console.WriteLine("Digite O Gênero Da Pessoa: ");
    b.genero = (Console.ReadLine());
    Console.WriteLine("A Marca Da Blusa É {0} O Tamanho Da Blusa É {1} O Gênero Da Pessoa É {2} ", b.marca, b.tamanho, b.genero);
    Console.WriteLine(b);
  }
}
public class blusa{
  public string marca;
  public string tamanho;
  public string genero;
}
}