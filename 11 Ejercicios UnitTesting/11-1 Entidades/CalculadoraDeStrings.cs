using System;

namespace _11_1_Entidades
{

    //En este ejercicio se trata de complejizar las pruebas de un mismo Metodo
    //de manera que al mismo tiempo el metodo se complejise pasando los posibles testeo.
    //La version final del metodo seria AddV5 de la PARTE 5

    public class CalculadoraDeStrings
    {
        //PARTE 1
        public int AddV1(string numero)
        {
            string[] numeros = numero.Split(',');
            int auxNum = 0;

            for (int i = 0; i < 2; i++)
            {
                int n = 0;
                if (int.TryParse(numeros[i], out n) && numeros[i] != string.Empty)
                {
                    auxNum += n;
                }
            }
            return auxNum;
        }
        //PARTE 2
        public int AddV2(string numero)
        {
            string[] numeros = numero.Split(',');
            int auxNum = 0;

            foreach (string str in numeros)
            {
                int n = 0;
                if (int.TryParse(str, out n) && str != string.Empty)
                {
                    auxNum += n;
                }
            }
            return auxNum;
        }
        //PARTE 3
        public int AddV3(string numero)
        {
            string[] numeros = numero.Split(',','\n');
            int auxNum = 0;

            foreach (string str in numeros)
            {
                int n = 0;
                if (int.TryParse(str, out n) && str != string.Empty)
                {
                    auxNum += n;
                }
            }
            return auxNum;
        }
        //PARTE 4
        public int AddV4(string numero)
        {
            string[] numeros = numero.Split(',','\n','/',';','-','_');
            int auxNum = 0;

            foreach (string str in numeros)
            {
                int n = 0;
                if (int.TryParse(str, out n) && str != string.Empty)
                {
                    auxNum += n;
                }
            }
            return auxNum;
        }
        //PARTE 5
        public int AddV5(string numero)
        {
            string[] numeros = numero.Split(',', '\n', '/', ';','_');
            int auxNum = 0;
            try
            {
                foreach (string str in numeros)
                {
                    int n = 0;
                    if (int.TryParse(str, out n) && str != string.Empty)
                    {
                        if (n < 0)
                        {
                            throw new System.Exception($"{n}");
                        }
                        auxNum += n;
                    }
                }
                return auxNum;
            } catch (Exception ex)
            {
                throw new Exception($"Numero negativo no permitido:",ex);
            }
         
        }
    }
}
