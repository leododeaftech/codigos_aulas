// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplificando um array...");

Console.WriteLine("Quantos nomes vc quer adicionar no sistema? Informe aqui: ...");
int qtdeNomes = int.Parse(Console.ReadLine()!);
if(qtdeNomes > 0){
string[] nomes = new string[qtdeNomes];

    for(int posicaoNome = 0; posicaoNome < qtdeNomes; posicaoNome++){
        Console.WriteLine("Informe o nome: ...");
        nomes[posicaoNome] = Console.ReadLine()!;
    }
    
    List<string> list = nomes.ToList();
    list.Add("DeafTech");
    foreach(string nome in list) Console.WriteLine("Voce digitou o nome {0}",nome);


}



