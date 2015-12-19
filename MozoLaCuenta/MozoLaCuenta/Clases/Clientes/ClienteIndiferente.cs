namespace MozoLaCuenta.Clientes
{
    public class ClienteIndiferente : Cliente
    {
        public ClienteIndiferente(double dineroEnElBolsillo, Comida comida) :
            base(dineroEnElBolsillo, comida)
        {

        }
        public override double propina()
        {
            return dineroEnElBolsillo;
        }
    }
}
