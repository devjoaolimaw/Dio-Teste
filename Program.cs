
using System.Globalization;
using Models;
using Propriedadesaula.Models;
using Newtonsoft.Json;
using System.Data.Common;


MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);


MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);


List<int> lista = new List<int>();



















// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = false;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



















// string conteudoArquivo = File.ReadAllText("C:/dev/Propriedadesaula/Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo); 

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaVenda)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }





















// var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80M};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);























// string conteudoArquivo = File.ReadAllText("C:/dev/Propriedadesaula/Arquivos/vendas.json");

// List<Venda> listaVena = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVena)
// {
//     Console.WriteLine(@$"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, 
//     Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



























// bool? desejaRecebrEmail = true;

// if (desejaRecebrEmail.HasValue && desejaRecebrEmail.Value)
// {
//     Console.WriteLine("O usuario optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuario nao respondeu ou optou por nao receber e-mail");
// }






































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
























// string conteudoArquivo = File.ReadAllText("C:/dev/Propriedadesaula/Arquivos/vendas.json");

// List<Venda> listaVena = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVena)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }



























// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("C:/dev/Propriedadesaula/Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Models
// {
//     public class Venda
//     {
//         public Venda(int id, string produto, decimal preco, DateTime dataVenda)
//         {
//             Id = id;
//             Produto = produto;
//             Preco = preco;
//             DataVenda = dataVenda;
//         }
//         public int Id { get; set; }
//         public string Produto { get; set; }
//         public decimal Preco { get; set; }
//         public DateTime DataVenda { get; set; }
//     }
// }






// int numero = 15;
// bool ehPar = false;

// //If ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é impar");
// }


























// Pessoa p1 = new Pessoa("Joao", "Brito");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

























// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoleitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }



















// (int, string, string, decimal) tupla = (1, "Joao", "Lima", 1.80M);

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Joao", "Lima", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Joao", "Lima", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");



























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// Console.WriteLine("-------------");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente:{chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não exixtente. É seguro adicionar a chave: {chave}");
// }













// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }















// new ExemploExcecao().Metodo1();

























// try
// { 

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminha da pasta não encontrado. " + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou ate aqui");
// }







































// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                                     "yyyy-MM-dd HH:mm", 
//                                     CultureInfo.InvariantCulture, 
//                                     DateTimeStyles.None, out DateTime date);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {date}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// DateTime data = DateTime.Parse("30/04/2022 18:00");
// Console.WriteLine(data);





































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123241;

// Console.WriteLine(numero.ToString("##-##-##"));

























// Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Brito", idade: 25);
// Pessoa p2 = new Pessoa(nome: "Alan", sobrenome: "Neves", idade: 23);


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Espanhol";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();





















// Pessoa p1 = new Pessoa();
// p1.Nome = "Joao";
// p1.Sobrenome = "Paulo";
// p1.Idade = 18;  
// p1.Apresentar();