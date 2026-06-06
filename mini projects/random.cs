// 1 — criar o sorteador e sortear
Random sorteador = new Random();
int numeroSecreto = sorteador.Next(1, 11); 

// 2 — criar variável do palpite
int palpite = 0;

// variável para contar tentativas (+)
int tentativas = 0;

// 3 — while enquanto não acertar
while (palpite != numeroSecreto)
{
    // 4 — pedir palpite ao jogador
    // ReadLine como string -- converter
    
    Console.WriteLine("Diga um número de 1 a 10");
    string chute = Console.ReadLine()!; //chute vai armazenar a resposta do usuário. O ! é para dizer que a resposta não vai ser nula, ou seja, o usuário vai digitar algo.
    palpite = int.Parse(chute); //converte a resposta do usuário para inteiro e armazena em palpite

    // 5 — comparar e dar dica
    if (numeroSecreto > palpite)
    {
    Console.WriteLine("Chuta mais alto!");
    }
    else if (numeroSecreto < palpite)
    {
    Console.WriteLine("Chuta mais baixo!");
     }

    // Somar 1 cada vez que o jogador tenta
    tentativas++;
}

// 6 — mensagem final
Console.WriteLine("Parabéns, você acertou o número secreto que era " + numeroSecreto + "!");
Console.WriteLine("E só precisou de " + tentativas + " tentativas!");
