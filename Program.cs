int x, y;
Console.Clear();
void frase(string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
    Console.Write(txt[i]);
    Thread.Sleep(75);        
    }
}
void resul()
{
    frase($"Seu ponto ({x},{y}) está no ");
}
Console.ForegroundColor = ConsoleColor.Blue;
frase("O valor do X: ");
Console.ForegroundColor = ConsoleColor.White;
x = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.Red;
frase("O valor do Y: ");
Console.ForegroundColor = ConsoleColor.White;
y = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.Cyan;
resul();
if (x == 0 && y == 0)
{
frase($"centro.\n");
Console.WriteLine(" ▫┃▫");
Console.WriteLine("━━X━━");
Console.WriteLine(" ▫┃▫");
}
else if (x == 0 && y > 0)
{
frase($"eixo das ordenadas.\n");
Console.WriteLine(" ▫ʌ▫");
Console.WriteLine("━━╋━━");
Console.WriteLine(" ▫V▫");
}
else if (x > 0 && y == 0)
{
frase($"eixo das abscissas.\n");
Console.WriteLine(" ▫┃▫");
Console.WriteLine("<━╋━>");
Console.WriteLine(" ▫┃▫");
}
else if (x > 0 && y > 0)
{
frase($"quadrante 1.\n");
Console.WriteLine(" ▫┃▪");
Console.WriteLine("━━╋━━");
Console.WriteLine(" ▫┃▫");
}
else if (x < 0 && y > 0)
{
frase($"quadrante 2.\n");
Console.WriteLine(" ▪┃▫");
Console.WriteLine("━━╋━━");
Console.WriteLine(" ▫┃▫");
}
else if (x < 0 && y < 0)
{
frase($"quadrante 3.\n");
Console.WriteLine(" ▫┃▫");
Console.WriteLine("━━╋━━");
Console.WriteLine(" ▪┃▫");
}
else if (x > 0 && y < 0)
{
frase($"quadrante 4.\n");
Console.WriteLine(" ▫┃▫");
Console.WriteLine("━━╋━━");
Console.WriteLine(" ▫┃▪");
}
Console.ResetColor();