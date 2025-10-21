using Estudo_Serializacao_Desserializacao.Models;

var Livro = new LivroModel(1, "Pequeno principe", "Json");


Console.WriteLine("--- 1. SERIALIZAÇÃO BÁSICA (Objeto C# -> JSON) ---");

string SerealizacaoObj = LivroModel.Serealizar(Livro);

Console.WriteLine(SerealizacaoObj);

Console.WriteLine();

Console.WriteLine("\n--- 2. DESSERIALIZAÇÃO (JSON -> Objeto C#) ---");

string jsonRecebido = @"{
    ""IdLivro"": ""202"",
    ""Autor"": ""José"",
    ""Titulo"": ""Padrões de Projeto"",
    ""DataPublicacao"": ""21-10-1994""
}";

try
{
    var livroDesserializado = LivroModel.Desserializar(jsonRecebido);

    Console.WriteLine($"Autor do livro: {livroDesserializado?.Autor}");
    Console.WriteLine($"Título do livro: {livroDesserializado?.Titulo}");
    Console.WriteLine($"ID: {livroDesserializado?.IdLivro} (Desserializado com sucesso de string para int!)");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro durante a desserialização: {ex.Message}");
}