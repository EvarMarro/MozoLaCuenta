namespace MozoLaCuenta.Clientes
{
    public abstract class Cliente
    {
        internal double dineroEnElBolsillo;
        internal Comida comida;

        public Cliente(double dineroEnElBolsillo, Comida comida)
        {
            this.dineroEnElBolsillo = dineroEnElBolsillo;
            this.comida = comida;
        }

        public double calcularCosto()
        {
            return comida.precio + propina();
        }

        public abstract double propina();
    }
}
