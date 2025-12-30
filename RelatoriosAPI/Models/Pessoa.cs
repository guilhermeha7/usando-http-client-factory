using System.Text.Json.Serialization;

namespace RelatoriosAPI.Models
{
    public class Pessoa
    {
        [JsonPropertyName("id")] //No processo de deserealização, Id receberá o valor da propriedade id
        public int Id { get; set; }

        [JsonPropertyName("nome")] //No processo de deserealização, Nome receberá o valor da propriedade nome
        public string Nome { get; set; }
    }
}
