namespace MozoLaCuenta.Clientes
{
    public class ClienteIndiferente : Cliente
    {
        private double dineroEnElBolsillo;
        public ClienteIndiferente(double dineroEnElBolsillo, Comida comida) :
            base(comida)
        {
            this.dineroEnElBolsillo = dineroEnElBolsillo;
        }
        public override double propina()
        {
            return dineroEnElBolsillo;
        }
    }
}
