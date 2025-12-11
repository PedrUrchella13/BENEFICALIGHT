namespace BENEFICALIGHT.Models
{
    public class Tratamento
    {
        public int TratamentoId { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
    }
}
