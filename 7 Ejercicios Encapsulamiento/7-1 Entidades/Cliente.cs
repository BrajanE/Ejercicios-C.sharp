namespace _7_1_Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre)
            : this(numero)
        {
            Nombre = nombre;
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value || string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }
        public int Numero
        {
            get { return numero; }
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.Numero == c2.Numero);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
