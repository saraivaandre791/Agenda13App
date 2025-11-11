using System;

namespace Agenda13App.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração em dias
        public int DuracaoEmDias
        {
            get
            {
                TimeSpan diferenca = DataFim - DataInicio;
                return diferenca.Days;
            }
        }

        // Calcula o custo total
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}
