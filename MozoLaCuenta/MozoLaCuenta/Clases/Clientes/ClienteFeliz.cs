namespace MozoLaCuenta.Clientes
{
    public class ClienteFeliz: Cliente
    {
        public ClienteFeliz(Comida comida) : base(comida) {}

        public override double propina()
        {
            return comida.precio * 0.25;
        }
    }
}
