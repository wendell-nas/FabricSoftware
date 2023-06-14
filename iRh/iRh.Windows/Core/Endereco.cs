using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public Endereco ObterPorCep(string cep)
        {
            var enderecoDaApi = new Endereco();

            var http = new HttpClient();
            var url = new Uri("https://viacep.com.br/ws/ " + cep + "/json/");
            var result = http.GetAsync(url).GetAwaiter().GetResult();
            var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            enderecoDaApi = JsonConvert.DeserializeObject<Endereco>(resultContent);

            return enderecoDaApi;
        }
    }
}
