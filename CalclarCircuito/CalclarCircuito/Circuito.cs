using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalclarCircuito
{
    public class Circuito
    {
        public int Id { get; set; }

        public int posX { get; set; }

        public int posY { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }



        public Circuito()
        {

        }


        public void imprimirCircuito(int id)
        {
            if (id == 0)
            {
                CrearBateria(posX, posY);
            }
        } 


        public void CrearCable()
        {

        }

        public int CrearBateria(int X, int Y)
        { 
            int XMax = X + 11;
            int XMedio = X + 5;

            for (int i = X; i < XMax; i++)
            {
                Console.SetCursorPosition(i, Y);
                if (i == XMedio)
                {
                    Console.WriteLine("┴");
                }
                else
                {
                    Console.WriteLine("─");
                }

            }

            int valorRetornableParaLaSalida = XMedio;

            X = X + 2;
            XMax = X + 7;
            XMedio = X + 3;
            int YAbajo = Y + 1;

            for (int i = X; i < XMax; i++)
            {
                Console.SetCursorPosition(i, YAbajo);

                if (i == XMedio)
                {
                    Console.WriteLine("┬");
                }
                else
                {
                    Console.WriteLine("─");
                }
            }
            
            return valorRetornableParaLaSalida;

        }
    }
}
