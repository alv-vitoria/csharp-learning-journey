/*
=== MENU PRINCIPAL ===
1 - Novo jogo
2 - Carregar jogo
3 - Opções
4 - Sair

Escolha uma opção:  

menu aparece → você escolhe → programa reage → menu volta
menu aparece → você escolhe 4 → "Saindo..." → "Até mais!" → fim
 */

// Montando do zero
using System.Threading; //para usar o Thread.Sleep() e dar um tempinho para o usuário ler a mensagem antes de fechar o programa

int escolha = 0; //variável para guardar a escolha do usuário - começa com 0 para o while funcionar

//melhor que "sair", coloque os numeros — usuário digita 4 para sair
while (escolha != 4) //"!= diferente de"
{
 //escolha do menu
 Console.WriteLine("=== MENU PRINCIPAL ===");
 Console.WriteLine("1 - Novo jogo");
 Console.WriteLine("2 - Carregar jogo");
 Console.WriteLine("3 - Opções");
 Console.WriteLine("4 - Sair");
 Console.WriteLine("Escolha uma opção: ");

 //agora lê o comando do usuário
 string texto = Console.ReadLine()!;
 escolha = int.Parse(texto); //converte o texto para inteiro e guarda na variável "escolha")

 // reage a escolha do usuário
 if (escolha == 1)
  {
    Console.WriteLine("Novo jogo selecionado");
  }

 else if (escolha == 2)
  {
    Console.WriteLine("Carregar jogo selecionado");
  }

 else if (escolha == 3)
  {
    Console.WriteLine("Opções selecionado");
  }
 
 else if (escolha == 4)
  {
    Thread.Sleep(1000);
    Console.WriteLine("Saindo do jogo...");
  }
 
 else
  {
    Console.WriteLine("Opção inválida, tente novamente.");
  }

}
Thread.Sleep(1000);
Console.WriteLine("Até mais!");
