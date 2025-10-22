using System.Text.Json;
using Newtonsoft.Json;

namespace Estudo_Serializacao_Desserializacao.Models
{
    public class LivroModel
    {
        [JsonProperty(nameof(IdLivro))]
        public int IdLivro { get; set; }

        [JsonProperty(nameof(Titulo))]
        public string Titulo { get; set; }

        [JsonProperty(nameof(Autor))]
        public string Autor { get; set; }

        [JsonProperty(nameof(DataPublicacao))]
        public DateTime DataPublicacao { get; set; }

        [JsonIgnore]
        public string SenhaInterna { get; set; } = "1111";

        [JsonConstructor]
        public LivroModel(int IdLivro, string Titulo, string autor, DateTime datapublicacao)
        {
            this.IdLivro = IdLivro;
            this.Autor = autor;
            this.Titulo = Titulo;
            this.DataPublicacao = datapublicacao;
        }
        
        private static JsonSerializerSettings settings { get; } = new JsonSerializerSettings
        {
            DateFormatString = "dd/MM/yyy",
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string Serealizar(LivroModel livro)
        {
            return JsonConvert.SerializeObject(livro, settings);
        }

        public static LivroModel Desserializar(string livro)
        {
            return JsonConvert.DeserializeObject<LivroModel>(livro, settings);
        }
        

    }
}