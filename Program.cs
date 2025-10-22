using Estudo_Serializacao_Desserializacao.Models;

var Livro = new LivroModel(1, "Pequeno principe", "Json", new DateTime(2003, 03, 30));


Console.WriteLine("--- 1. SERIALIZAÇÃO BÁSICA (Objeto C# -> JSON) ---");

string SerealizacaoObj = LivroModel.Serealizar(Livro);

Console.WriteLine(SerealizacaoObj);


Console.WriteLine("\n--- 2. DESSERIALIZAÇÃO (JSON -> Objeto C#) ---");

// Simular um json recebido de uma API
string jsonRecebido = @"{
    ""IdLivro"": ""202"",
    ""Autor"": ""José"",
    ""Titulo"": ""Padrões de Projeto"",
    ""DataPublicacao"": ""1994-12-10""
}";

try
{
    var livroDesserializado = LivroModel.Desserializar(jsonRecebido);

    Console.WriteLine($"ID: {livroDesserializado?.IdLivro} (Desserializado com sucesso de string para int!)");
    Console.WriteLine($"Autor do livro: {livroDesserializado?.Autor}");
    Console.WriteLine($"Título do livro: {livroDesserializado?.Titulo}");
    Console.WriteLine($"Data da Publicação: {livroDesserializado?.DataPublicacao.ToString("dd/MM/yyy")}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro durante a desserialização: {ex.Message}");
}