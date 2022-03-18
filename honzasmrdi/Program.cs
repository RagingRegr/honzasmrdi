
Console.WriteLine("LIST SMRADOCHU\n");
kalkulace("Adam Hanzlík");
kalkulace("Adam Pala");
kalkulace("Adam Kijonka");
kalkulace("Miroslav Přeček");
kalkulace("Matěj Bartusek");
kalkulace("Jan Rada");
kalkulace("Ondřej Valenta");

static void kalkulace(string jmeno)
{
    int soucet=0;
    double prumer;
    for (int i=0;i<jmeno.Length;i++)
    {
        soucet+=(int)jmeno[i];
    }
    prumer = (double)soucet / jmeno.Length;
    prumer=Math.Round(prumer);
    Console.Write($"{jmeno}\t");
    if (prumer % 7 == 0 || jmeno=="Jan Rada")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("smrdí jako bolavá noha bezdomovce");
    }
    else if (prumer % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("smrdí jako knoňská říť");
    }
    else if (prumer % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("smrdí jako cibuláč");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("nesmrdí");
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
