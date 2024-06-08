// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao sistema de saldos!");
Console.WriteLine("--------------------------------");
Console.WriteLine("Insira a quantidade de entradas");
int quantidadeEntrada = int.Parse(Console.ReadLine()!);
int somaE = 0;

for(int contador = 0; contador < quantidadeEntrada;contador ++){
Console.WriteLine("--------------------------------");
Console.WriteLine("Insira o valor da entrada (Ex. Salario, mesada, etc...)");
    somaE += int.Parse(Console.ReadLine()!);
}

Console.WriteLine("A sua soma das entradas foi de "+somaE);
Console.WriteLine("--------------------------------");



Console.WriteLine("Insira a quantidade de saídas");
int quantidadeSaida = int.Parse(Console.ReadLine()!);
int somaS = 0;

for(int contador = 0; contador < quantidadeSaida;contador ++){
Console.WriteLine("--------------------------------");
Console.WriteLine("Insira o valor da saída (Ex. Contas, cartão, etc...)");
    somaS += int.Parse(Console.ReadLine()!);
}

Console.WriteLine("A sua soma de saídas foi de "+somaS);

Console.WriteLine("A seu saldo é de  "+ (somaE - somaS));

if((somaE - somaS) < 0){
    Console.WriteLine("Saldo negativo");
}
