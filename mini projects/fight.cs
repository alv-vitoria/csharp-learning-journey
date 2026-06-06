 
int jogadorHP = 100;
int enemyHP = 50;

Random dado = new Random(); //CRIA UM OBJETO PARA GERAR NÚMEROS ALEATÓRIOS

while (jogadorHP > 0 && enemyHP > 0) //enquanto ambos estiverem vivos (&& verificar se as duas condições são verdadeiras)
{
    int danoJogador = dado.Next(10, 21); // Dano entre 10 e 20
    int danoInimigo = dado.Next(5, 16); // Dano entre 5 e 15

    // jogador ataca
    enemyHP -= danoJogador;
    if (enemyHP < 0)
    {
        enemyHP = 0;
    }

    Console.WriteLine("Jogador ataca inimigo causando " + danoJogador + " de dano.");
    Console.WriteLine("Vida do inimigo: " + enemyHP);
    Console.WriteLine();

    // Se o inimigo morreu, não pode atacar
    if (enemyHP == 0)
    {
        break; //sai do loop, porque o inimigo morreu
    }

    // Inimigo ataca
    jogadorHP -= danoInimigo;

    if (jogadorHP < 0)
    {
        jogadorHP = 0;
    }

    Console.WriteLine("Inimigo ataca jogador causando " + danoInimigo + " de dano.");
    Console.WriteLine("Vida do jogador: " + jogadorHP);
    Console.WriteLine();
}

if (jogadorHP == 0)
{
    Console.WriteLine("Você perdeu...");
}
else
{
    Console.WriteLine("Parabéns, tu venceu!");
}
