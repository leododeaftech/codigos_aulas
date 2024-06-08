// See https://aka.ms/new-console-template for more information
// E

Console.WriteLine("Digite um número para começar");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("**************************");
Console.WriteLine("Condição E = &&");
if(numero > 5 && numero > 2)
{
    Console.WriteLine("é maior que 5 e é maior do que 2 \n");
}else Console.WriteLine("Não é maior que 5 e nem maior do que 2 \n");

Console.WriteLine("Condição OU = ||");
if(numero > 5 || numero > 2)
{
    Console.WriteLine("é maior que 5 ou é maior do que 2 \n");
}else Console.WriteLine("Não é maior que 5 e nem maior do que 2 \n");

Console.WriteLine("Condição negativa = !");
if(!(numero > 50))
{
    Console.WriteLine("Não é maior do que 50 \n" );
}else Console.WriteLine("É maior do que 50 \n");

Console.WriteLine("Condição de igualdade = ==");
if(numero == 10)
{
    Console.WriteLine("é igual a 10 \n");
}else Console.WriteLine("Não é igual a 10 \n");

Console.WriteLine("Condição de diferença = !=");
if(numero != 10)
{
    Console.WriteLine("é diferente do que 10\n");
} else Console.WriteLine("É igual a 10\n");   
