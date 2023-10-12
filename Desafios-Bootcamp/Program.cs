using System;
/*
 Desafio 
    * Se a taxa de sucesso for maior ou igual a 80%, o programa exibirá a mensagem "A funcionalidade esta pronta para lancamento."
    * Caso contrário, se a taxa de sucesso for menor que 80%, o programa exibirá a mensagem "A funcionalidade nao esta pronta para lancamento."
*/
namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      Console.WriteLine("Digite a quantidade de testes bem-sucedidos");
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite a quantidade de testes totais");
      // Solicita ao usuário a quantidade de testes totais:
      int testesTotais = int.Parse(Console.ReadLine());

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:
      double taxaDeSucesso = (double)testesBemSucedidos / testesTotais;
      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
      if(taxaDeSucesso >= 0.80)
      {
        Console.WriteLine($"A funcionalidade esta pronta para o lancamento. {taxaDeSucesso}");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine($"A funcionalidade nao esta pronta para o lancamento. {taxaDeSucesso}");
        Console.ReadLine();
      }
    }
  }
}
