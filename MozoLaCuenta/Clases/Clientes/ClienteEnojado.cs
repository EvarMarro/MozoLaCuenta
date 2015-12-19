namespace MozoLaCuenta.Clientes
{
    public class ClienteEnojado : Cliente
    {
        public ClienteEnojado(double dineroEnElBolsillo, Comida comida): base(dineroEnElBolsillo, comida) {}
        public override double propina()
        {
            return 0;
        }
    }
}
