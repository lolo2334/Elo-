// REsolve uma equação de 2 grau usando a fómula de Bhaskara *

double a, b, c, delta, x1, x2;

Console.Write("--- Encontre o (x) da equação [ax² + bx + c]--\n");

Console.Write("Digite o valor de (a): ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de (b): ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de (c): ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nA equação é: {a}x² +`{b}x + {c}");

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" O valor informado para (a) é inválido. A equação não é de 2° grau.");
}
else
{
    delta = (b * b) - 4 * a * c;

    if (delta < 0)
    {
       Console.ForegroundColor = ConsoleColor.DarkRed;
       Console.WriteLine("A equação não possui raízes reaos.");
    }
    else
    { 
        x1 = (-b +  Math.Sqrt(delta)) / (2 * a);
       x2 = (-b -  Math.Sqrt(delta)) / (2 * a); 

       Console.WriteLine($"As raízes da equação são x1 = {x1} e x2 = {x2}");
    }
}

Console.ResetColor();




