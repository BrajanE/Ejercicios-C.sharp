using System.Collections.Generic;

namespace _7_2_Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                return string.Empty;
            }
            set
            {
                if (i >= 0 && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }

            }
        }
    }

}
