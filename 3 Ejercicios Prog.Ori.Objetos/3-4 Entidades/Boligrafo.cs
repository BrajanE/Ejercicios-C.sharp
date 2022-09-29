using System;

namespace _3_4_Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        private void SetTinta(short tinta)
        {
            if(cantidadTintaMaxima>=0 && cantidadTintaMaxima <= 100)
            {
                this.tinta += tinta;
            }
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            if (this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            for(int i = gasto; i > 0; i--)
            {
                if(GetTinta() == 0)
                {
                    break;
                }
                this.tinta--;
                dibujo += "*";
                //impresion += "*";
            }       
            return true;
        }
    }
}
