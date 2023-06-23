namespace BibliotecaDeClases
{
    public class SaldoInsuficienteException : Exception
    {
        public float SaldoActual { get; }
        public float MontoRequerido { get; }

        public SaldoInsuficienteException(float saldoActual, float montoRequerido)
        {
            SaldoActual = saldoActual;
            MontoRequerido = montoRequerido;
        }
        public override string Message
        {
            get
            {
                return $"Saldo insuficiente. Saldo actual: {SaldoActual}, Monto requerido: {MontoRequerido}";
            }
        }
    }
}