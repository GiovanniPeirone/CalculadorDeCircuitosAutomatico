// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Console.CursorVisible = false;

Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);


void CrearBateria(int X, int Y)
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
}
bool MenuUno(int posY)
{
    ConsoleKeyInfo FlechaY;
    int posFlechaY = 1;
    while (true)
    {
        
    }
    
}



int BateriaPosX = 30;
int BateriaPosY = 30;
ConsoleKeyInfo consoleKeyInfo;

//bool main = MenuUno(Console.LargestWindowHeight / 2);

while (true)
{
    

    CrearBateria(BateriaPosX, BateriaPosY);


    consoleKeyInfo = Console.ReadKey(true);

    if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
    {
        BateriaPosX += 1;
    }
    if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
    {
        BateriaPosX -= 1;
    }
    if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
    {
        BateriaPosY -= 1;
    }
    if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
    {
        BateriaPosY += 1;
    }


    Console.Clear();
}

