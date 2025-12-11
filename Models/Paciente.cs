using System.Net.Mail;

namespace BENEFICALIGHT.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string TipoSanguineo { get; set; }

        //Chave Estrangeira
        public int MedicoId { get; set; }
        public Medico? Medico { get; set; }

    }
}
