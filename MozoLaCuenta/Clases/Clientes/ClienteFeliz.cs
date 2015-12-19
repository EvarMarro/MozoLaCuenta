namespace MozoLaCuenta.Clientes
{
    public class ClienteFeliz: Cliente
    {
        public ClienteFeliz(double dineroEnElBolsillo, Comida comida) : base(dineroEnElBolsillo, comida) {}

        public override double propina()
        {
            return comida.precio * 0.25;
        }
    }
}
