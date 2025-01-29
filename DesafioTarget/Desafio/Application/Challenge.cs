using Newtonsoft.Json;

namespace Desafio.Application
{
    public class Challenge : IChallenge
    {
        public string ChallengeOne()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            return $"O valor final de SOMA é: {SOMA}";
        }

        public string ChallengeTwo(int numero)
        {
            bool pertence = BelongsFibonacci(numero);

            if (pertence)
            {
                return $"O número : {numero} pertence a Escala Fibonacci";
            }
            else
            {
                return $"O número: {numero} não pertence a Escala Fibonacci";
            }
        }

        public string ChallengeThree()
        {
            string jsonInvoicing = "[{\"dia\":1,\"valor\":221.3},{\"dia\":2,\"valor\":300.5},{\"dia\":3,\"valor\":0},{\"dia\":4,\"valor\":500.75},{\"dia\":5,\"valor\":0},{\"dia\":6,\"valor\":700.1},{\"dia\":7,\"valor\":0}]";

            var billings = JsonConvert.DeserializeObject<Invoicing[]>(jsonInvoicing);

            var billingDays = billings.Where(f => f.Valor > 0).ToList();

            double lowerRevenue = billingDays.Min(f => f.Valor);
            double biggerBilling = billingDays.Max(f => f.Valor);

            double monthlyDay = billingDays.Average(f => f.Valor);

            int daysAboveAverage = billingDays.Count(f => f.Valor > monthlyDay);

            return $"Menor faturamento: {lowerRevenue:C}, Maior faturamento: {biggerBilling:C}, e Dias com faturamento acima da média: {daysAboveAverage}";
        }

        public List<string> ChallengeFour()
        {
            var percentages = new List<string>();
            var BillingByState = new[]
            {
            new { State = "SP", value = 67836.43 },
            new { State = "RJ", value = 36678.66 },
            new { State = "MG", value = 29229.88 },
            new { State = "ES", value = 27165.48 },
            new { State = "Outros", value = 19849.53 }
            };

            double faturamentoTotal = 0;
            foreach (var estado in BillingByState)
            {
                faturamentoTotal += estado.value;
            }

            foreach (var estado in BillingByState)
            {
                double percentual = (estado.value / faturamentoTotal) * 100;
                percentages.Add($"{estado.State}: {percentual:F2}%");
            }
            return percentages;
        }

        public string ChallengeFive(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] caracteres = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                caracteres[i] = str[j];
            }

            return new string(caracteres);
        }

        private bool BelongsFibonacci(int numero)
        {
            if (numero == 0 || numero == 1) return true;

            int a = 0, b = 1;
            while (b < numero)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b == numero;
        }
    }

    class Invoicing
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
