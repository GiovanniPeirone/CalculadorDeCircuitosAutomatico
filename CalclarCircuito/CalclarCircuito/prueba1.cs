using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalclarCircuito
{

    public class listaComponentes
    {
        


    }

    public class prueba1
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int posSalidaX { get; set; }

        public int posSalidaY { get; set; }


        List<prueba1> pruebaLista = new List<prueba1>
        {
            //new prueba1(){ Id = 1, Nombre = "pila", PosX = 20, PosY = 20, posSalidaX = 10, possalidaY = 10 },
            //new prueba1(){ Id = 2, Nombre = "cable", PosX = 10  }//....
        };

        public void run()
        {
            int posX = 20;
            int posY = 20;

            Circuito bateria = new Circuito();

            int possalidaX = bateria.CrearBateria(posX, posY);
            int possalidaY = posY;

            int id = 1;

            pruebaLista.AddRange(id, 3, posX, posY, possalidaX, possalidaY);
            

            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo1 = Console.ReadKey(); 

                switch (consoleKeyInfo1.Key)
                {
                    case ConsoleKey.Enter:

                        
                        break;

                }




                Console.Clear();
                Id++;
            }
        }

        
    }
}
