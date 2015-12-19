namespace MozoLaCuenta.Clientes
{
    public class ClienteEnojado : Cliente
    {
        public ClienteEnojado(Comida comida): base(comida) {}
        public override double propina()
        {
            return 0;
        }
    }
}
