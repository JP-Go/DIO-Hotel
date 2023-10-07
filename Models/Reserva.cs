namespace Hotel.Models
{
    public class Reserva
    {
        private static decimal pct_desconto = 0.1M;

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva() { }

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new ArgumentException("Número de Hóspedes maior que a capacidade da suíte.");
            }
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Equivalente ao CalcularValorDiária sugerido no desafio. O nome
        // CalcularValorReserva para mim é melhor que o sugerido pois na verdade
        // estamos calculando o valor da reserva dados os dias reservados e a
        // diária da suíte
        public decimal CalcularValorReserva()
        {
            decimal total =
                DiasReservados >= 10
                    ? Suite.ValorDiaria * DiasReservados * (1 - pct_desconto)
                    : Suite.ValorDiaria * DiasReservados;
            return total;
        }
    }
}
