using Calculadora_api.Model;
using System.Text.Json;

namespace Calculadora_api.Services
{
    public class HistoricoService
    {
        private readonly List<Historico> _historico;

        public HistoricoService()
        {
            _historico = new List<Historico>();
        }
        public void AdicionarHistorico(string operacao)
        {
            string[] partes = operacao.Split(',');

            _historico.Add(new Historico(
                    partes[0],
                    decimal.Parse(partes[1]),
                    decimal.Parse(partes[2]),
                    decimal.Parse(partes[3]),
                    DateTime.Now)
                );

            Console.WriteLine($"Operação adicionada ao histórico: {operacao}");

            var options = new JsonSerializerOptions { WriteIndented = true };

            //string fileName = "$./Repository/HistoricoCalculadora.json";
            string fileName = $"./Repository/HistoricoCalculadora_{DateTime.Now:yyyy-MM-dd}.json";

            using FileStream createStram = File.Create(fileName);
            JsonSerializer.SerializeAsync(createStram, _historico, options);

            //string jsonString = JsonSerializer.Serialize(_historico, options);

            //Console.WriteLine(jsonString);


            //_historico.Add(operacao);
            //Console.WriteLine($"Operação adicionada ao histórico: {operacao}");

            //string fileName = "./Repository/HistoricoCalculadora.json";
            //await using FileStream createStram = File.Create(fileName);
            //await JsonSerializer.SerializeAsync(createStram, _historico);
            //Console.WriteLine(File.ReadAllText(fileName));

        }
        public List<Historico> ObterHistorico()
        {
            string fileName = $"./Repository/HistoricoCalculadora_{DateTime.Now:yyyy-MM-dd}.json";

            if (!File.Exists(fileName))
            {
                return new List<Historico>();
            }

            string jsonString = File.ReadAllText(fileName);

            return JsonSerializer.Deserialize<List<Historico>>(jsonString) ?? new List<Historico>();
        }
    }
}

