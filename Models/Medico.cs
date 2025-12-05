namespace BENEFICALIGHT.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int CRM { get; set; }
        public int CPF { get; set; }
        public string Hospital { get; set; }

        public int EspecializacaoId { get; set; }
        public Especializacao? Especializacao { get; set; }

    }
}
