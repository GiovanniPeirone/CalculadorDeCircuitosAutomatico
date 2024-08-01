// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CalclarCircuito;


Console.CursorVisible = false;

Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);



int ID = 1;
int BateriaPosX = 30;
int BateriaPosY = 30;
ConsoleKeyInfo consoleKeyInfo;
Circuito circuito = new Circuito();
UI ui = new UI();

List<Circuito> circuitoList;


//bool main = MenuUno(Console.LargestWindowHeight / 2);


//pasos de creacion
//paso 1 : crear bateria (requerimientos(posiscionXY , funcion mara imprimirlo, posicion de salidaXY))
//paso 2 : guardar en una lista la posicion de la bateria y la pos de la salida ademas de darle un id 
//paso 3 : crear cable (requerimiento (posicionXY la cual va a ser la salida del elemento anterior, posicion de laida))

//pasos de Imprimir 
//paso 1 : ver el id de el elemnto (si es 0 va a ser siempre la vateria lor lo cual se deve imprimir la funcion de bateria) si no cable os recistencia o cualquier otro compnente del sircuito
//         este se deve imprimir en la posicionXY guardada en la lista
//paso 2 : sumar 1 a y para luego volverlo a comparar con el sigiente valor de la lista y sus datos
//paso 3 : repetir este proseso hasta que lla no queden mas componentes

//pasos para calcular

//pasos para circuito paralelo



while (true)
{




    /*
    //ui.MenuUno(10);
   
    circuito.CrearBateria(BateriaPosX, BateriaPosY);

    int RotacionInicial = 90;

    //CadenaDecables cadenaDecables = new CadenaDecables();

    
    consoleKeyInfo = Console.ReadKey(true);

    switch (consoleKeyInfo.Key)
    {
        case ConsoleKey.RightArrow:

            BateriaPosX += 1;
            break;

        case ConsoleKey.LeftArrow:

            BateriaPosX -= 1;
            break;

        case ConsoleKey.UpArrow:

            BateriaPosY -= 1;
            break;

        case ConsoleKey.DownArrow:

            BateriaPosY  += 1;
            break;
    }
    

    if (RotacionInicial == 90)
    {
        Console.CursorVisible = true;
        switch (consoleKeyInfo.Key)
        {
            case ConsoleKey.W:
                Console.WriteLine("│");
                break;
            case ConsoleKey.A:
                Console.WriteLine("┐");
                break;
            case ConsoleKey.S:
                Console.WriteLine("┌");
                break;

            case ConsoleKey.Spacebar:
                CadenaDecables cadenaDecables = new CadenaDecables();
                cadenaDecables._id = ID;
                break;

            case ConsoleKey.Y:

                break;
        }
    }

    */

    ID++;
    Console.Clear();
}


struct CadenaDecables
{
    int posX ; 
    int posY;
    int Rotacion;
    public int _id;
};