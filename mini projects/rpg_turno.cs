// RPG de Turnos
// Conceitos: loop while, condicionais, Random, clamp de HP

int jogadorHP = 100;
int inimigoHP = 50;
int turno = 1;
Random dado = new Random();

while (jogadorHP > 0 && inimigoHP > 0)
{
    // --- Status do turno ---
    Console.WriteLine("=== TURNO " + turno + " ===");
    Console.WriteLine("Jogador: " + jogadorHP + " HP | Inimigo: " + inimigoHP + " HP");
    Console.WriteLine("1 - Atacar | 2 - Curar | 3 - Fugir");

    string texto = Console.ReadLine()!;
    int escolha = int.Parse(texto);

    // --- Ação do jogador ---
    if (escolha == 1)
    {
        int dano = dado.Next(10, 21);
        inimigoHP -= dano;
        Console.WriteLine("Você atacou e causou " + dano + " de dano!");
    }
    else if (escolha == 2)
    {
        if (jogadorHP == 100)
        {
            Console.WriteLine("Você já está com HP máximo!");
        }
        else
    {
        int cura = dado.Next(15, 26);
        jogadorHP += cura;
        if (jogadorHP > 100) jogadorHP = 100;
        Console.WriteLine("Você se curou e recuperou " + cura + " de HP!");
    }
}
    }
    else if (escolha == 3)
    {
        Console.WriteLine("Você fugiu!");
        break; //para tudo
    }

    // --- Ataque do inimigo, se estiver vivo ---
    if (inimigoHP > 0)
    {
        int dano = dado.Next(5, 16);
        jogadorHP -= dano;
        Console.WriteLine("O inimigo causou " + dano + " de dano em você!");

    }
    else
    {
        Console.WriteLine("O inimigo foi derrotado! Parabéns!");
    }

    turno++;
}
