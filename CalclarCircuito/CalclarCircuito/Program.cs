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


//bool main = MenuUno(Console.LargestWindowHeight / 2);



while (true)
{

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