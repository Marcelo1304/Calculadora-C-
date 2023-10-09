#README 
bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima && media >= 7){
    Console.WriteLine("Você foi aprovado!");
}
else{
    Console.WriteLine("Você foi Reprovado");
}

- SISTEMA MAIOR DE IDADE!

/bool ehMaiorDeIdade = false;
/bool possuiAutorizaçaoDoResponsavel = false;
/
/if(ehMaiorDeIdade || possuiAutorizaçaoDoResponsavel)
/{
/    Console.WriteLine("Entrada Liberada");
/}
/else{
/    Console.WriteLine("Entrada não liberada");
/}
/Console.WriteLine("Digite uma letra");
/string letra = Console.ReadLine();
/
/switch(letra){
/    case "a":
/    case "e":
/    case "i":
/    case "o":
/    case "u":
/    
/    Console.WriteLine("é uma vogal");
/    break;
/
/    default:
/    Console.WriteLine("Não é uma vogal");
/    break;
/}
/int quantidadeEmEstoque = 10;
/int quantidadeCompra =9; 
/bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;
/
/Console.WriteLine($"Quantidade em estoque:{quantidadeEmEstoque}");
/Console.WriteLine($"Quantidade de compra:{quantidadeCompra}");
/Console.WriteLine($"é possivel realizar a venda? {possivelVenda}");
/
/if(quantidadeCompra == 0){
/    
/}
/if(possivelVenda){
/    Console.WriteLine("Venda Realizada");
/}else{
/    Console.WriteLine("Desculpe não temos a quantidade em estoque");
/}
/Apartamento apartamento1 = new Apartamento();
/
/apartamento1.Cômodos1 = "Suites";
/apartamento1.Cômodos2 = "Cozinha";
/apartamento1.Cômodos3 = "Living";
/apartamento1.Cômodos4 = "Hidromassagem";
/
/apartamento1.ApresentarApartamento();
/int inteiro = 5;
/string a = inteiro.ToString();
/
/Console.WriteLine(a);
/int a = Convert.ToInt32("6");
/
/Console.WriteLine(a);
/
/
/int a = 10;
/int b = 20;
/
/int c = a + b;
/c = c + 5;  // 30 + 5 
/DateTime dataAtual = DateTime.Now.AddDays(5);
/Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
/string apresentacao = "Olá, seja bem vindo!";
/
/int quantidade = 1;
/
/double altura = 1.80;
/
/decimal preco = 1.80M;
/
/bool condicao = true;
/
/Console.WriteLine(apresentacao);
/Console.WriteLine("Valor da quantidade:" + quantidade);
/Console.WriteLine("Valor da altura:" + altura);
/Console.WriteLine("Valor da preco:" + preco);
/Console.WriteLine("Valor da condicao:" + condicao);
/
/
/Pessoa pessoa1 = new Pessoa();
/
/pessoa1.Nome = "Marcelo";
/pessoa1.Idade = 22;
/pessoa1.Apresentar();
/Variavel sempre com letra miniscula --> pessoaFisicaNatural  e  NÃO PessoaFisicaNatural
/using exemplosFundamentos.Casa;
/
/Casa  Cômodos1 =  new Casa();
/
/Cômodos1.Cômodos1 = "Quartos";
/Cômodos1.Cômodos2 = "Cozinha";
/Cômodos1.Cômodos3 = "Piscina";
/Cômodos1.Cômodos4 = "Garagem";
/Cômodos1.ApresentarCasa();