using System;

namespace _9_1_Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
        
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Sobrescrito);
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
