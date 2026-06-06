
int xp = 0;
int nivel = 1;
int xpNecessario = nivel * 100;
string entrada = "";

while (entrada != "sair")        // abre while externo
{
    Console.WriteLine("Quanto XP você ganhou? (ou 'sair' para sair)");
    entrada = Console.ReadLine()!;

    if (entrada != "sair")       // abre if
    {
        int xpGanho = int.Parse(entrada);
        xp += xpGanho;

        while (xp >= xpNecessario && nivel < 5)  // abre while interno
        {
            xp -= xpNecessario;
            nivel++;
            xpNecessario = nivel * 100;
            Console.WriteLine("LEVEL UP! Nível " + nivel);
        }                        // fecha while interno

        Console.WriteLine("Nível: " + nivel);
        Console.WriteLine("XP: " + xp);

        if (nivel >= 5)          // abre if nivel
        {
            Console.WriteLine("Parabéns! Nível máximo!");
        }                        // fecha if nivel
        else                     // abre else
        {
            int xpFalta = xpNecessario - xp;
            Console.WriteLine("Faltam " + xpFalta + " XP para o nível " + (nivel + 1));
        }                        // fecha else

    }                            // fecha if entrada

}                                // fecha while externo

Console.WriteLine("Até mais!");


