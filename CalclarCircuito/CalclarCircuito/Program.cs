// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


//Console.CursorVisible = false;


int InitialPosX = 60;
int InitialPosY = 1;
int Y = InitialPosX+1;

Console.WriteLine("Voltaje Inicial");
Double VoltionIniciales = Convert.ToDouble(Console.ReadLine());
Console.Clear();

List<Componentes> ListaDeComponentes = new List<Componentes>
{
    new Componentes { Name="BateriaInicial", posX=InitialPosX, posY=InitialPosY, Valor=VoltionIniciales},
};

void ImprimirBeteriaInicial(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("┬");
    
    Console.SetCursorPosition(ListaDeComponentes[i].posX +2 , ListaDeComponentes[i].posY);
    Console.WriteLine(ListaDeComponentes[i].Valor +"v");

}

void ImprimirCable(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("│");

    Console.SetCursorPosition(ListaDeComponentes[i].posX + 2, ListaDeComponentes[i].posY);
    Console.WriteLine(ListaDeComponentes[i].Valor + "I");
}

void ImprimirResistencia(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("@");

    Console.SetCursorPosition(ListaDeComponentes[i].posX + 2, ListaDeComponentes[i].posY);
    Console.WriteLine(ListaDeComponentes[i].Valor + "R");
}

void ImprimirCerrarCircuito(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("┴");

    Console.SetCursorPosition(ListaDeComponentes[i].posX + 2, ListaDeComponentes[i].posY);
    Console.WriteLine(ListaDeComponentes[i].Valor + "v");
}

void ImprimirGrafico() 
{
    for (int i = 0; ListaDeComponentes.Count > i; i++)
    {
        if (ListaDeComponentes[i].Name == "BateriaInicial")
        {
            ImprimirBeteriaInicial( i);
        }

        if (ListaDeComponentes[i].Name == "Cable")
        {
            ImprimirCable(i);
        }

        if (ListaDeComponentes[i].Name == "Resistencia")
        {
            ImprimirResistencia(i);
        }
    }
}

Y = 2;
Double Intensidad = 0;

while (true)
{
    ImprimirGrafico();

    ConsoleKeyInfo Key = Console.ReadKey(true);
    if ( Key.Key == ConsoleKey.C)
    {
        ListaDeComponentes.Add(new Componentes { Name= "Cable", posX=60, posY = Y, Valor=Intensidad });
        Y = Y + 1;
    }

    if (Key.Key == ConsoleKey.R)
    {
        Console.WriteLine("Valor De la Recistencia");
        Double ValorDeReccistencia = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Intensidad = VoltionIniciales / ValorDeReccistencia;
        ListaDeComponentes.Add(new Componentes { Name = "Resistencia", posX = 60, posY = Y, Valor = ValorDeReccistencia });
        Y = Y + 1;
    }

    if (Key.Key == ConsoleKey.Escape)
    {
        ListaDeComponentes.Add(new Componentes { Name = "CerrarCircuito", posX = 60, posY = Y, Valor = 0});
    }
}

public class Componentes
{
    public string? Name { get; set; }

    public int posX { get; set; }

    public int posY { get; set; }

    public Double Valor { get; set; }

}



