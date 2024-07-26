// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CalcularCircuito;

Console.CursorVisible = false;

Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);


void CrearBateria(int X,int Y)
{
    int XMax = X + 11;
    int XMedio = X + 5;

    for (int i = X; i < XMax ; i++)
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

void MenuUno(int posY)
{
    int posFlechaY = 1;
    while (true)
    {
        if (posFlechaY == 1)
        {
            Console.SetCursorPosition(10, posY);
            Console.WriteLine("[Comenzar]");
        }
        else
        {
            Console.SetCursorPosition(10, posY);
            Console.WriteLine(" Comenzar");
        }

        if (posFlechaY == 2)
        {
            Console.SetCursorPosition(10, posY + 1);
            Console.WriteLine("[Salir]");
        }
        else
        {
            Console.SetCursorPosition(10, posY + 1);
            Console.WriteLine(" Salir ");
        }

        if (ConsoleKey == ConsoleKey.Enter)
        {
            break;
        }

    }
}


int BateriaPosX = Console.LargestWindowWidth / 2;
int BateriaPosY = Console.LargestWindowHeight / 2;

while (true)
{
    //MenuUno(Console.LargestWindowHeight / 2);

    CrearBateria(BateriaPosX, BateriaPosY);
    /*
    if (ConsoleKey == ConsoleKey.W)
    {
        BateriaPosY - 1;
    }
    */
}

