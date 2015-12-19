namespace MozoLaCuenta.Clientes
{
    public abstract class Cliente
    {        
        internal Comida comida;

        public Cliente(Comida comida)
        {           
            this.comida = comida;
        }

        public double calcularCosto()
        {
            return comida.precio + propina();
        }

        public abstract double propina();
    }
}
