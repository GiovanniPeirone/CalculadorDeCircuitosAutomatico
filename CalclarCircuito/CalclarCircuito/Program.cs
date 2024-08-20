// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;


//Console.CursorVisible = false;


int InitialPosX = 60;
int InitialPosY = 4;
Double Intensidad = 0;
int Y = InitialPosX+1;

Console.WriteLine("Voltaje Inicial");
Double VoltionIniciales = Convert.ToDouble(Console.ReadLine());
Console.Clear();

List<Componentes> ListaDeComponentes = new List<Componentes>
{
    new Componentes { Name="BateriaInicial", posX=InitialPosX, posY=InitialPosY, Valor=VoltionIniciales},
};

List<Componentes> ResistenciaTotalLista = new List<Componentes>();

List<Ventanas> Ventanas = new List<Ventanas>();

void ImprimirBeteriaInicial(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("┬");
    
    Console.SetCursorPosition(ListaDeComponentes[i].posX +2 , ListaDeComponentes[i].posY);
    Console.WriteLine($"Pila = {ListaDeComponentes[i].Valor} V");

}

void ImprimirCable(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("│");

    Console.SetCursorPosition(ListaDeComponentes[i].posX + 2, ListaDeComponentes[i].posY);
    Console.WriteLine($"I = {ListaDeComponentes[i].Valor} A");
}

void ImprimirResistencia(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("@");

    Console.SetCursorPosition(ListaDeComponentes[i].posX + 2, ListaDeComponentes[i].posY);
    Console.WriteLine($"R = { ListaDeComponentes[i].Valor} ohm");
}

void ImprimirCerrarCircuito(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("┴");
    Console.WriteLine("FIN");
}

void ImprimirResistenciaParalela(int i)
{
    Console.SetCursorPosition(ListaDeComponentes[i].posX, ListaDeComponentes[i].posY);
    Console.WriteLine("┼");

}

void ImprimirGrafico() 
{
    for (int i = 0; ListaDeComponentes.Count > i; i++)
    {
        if (ListaDeComponentes[i].Name == "BateriaInicial")
        {
            ImprimirBeteriaInicial(i);
        }

        if (ListaDeComponentes[i].Name == "Cable")
        {
            ImprimirCable(i);
        }

        if (ListaDeComponentes[i].Name == "Resistencia")
        {
            ImprimirResistencia(i);
        }

        if (ListaDeComponentes[i].Name == "ResistenciaParalela")
        {
            ImprimirResistenciaParalela(i);
        }

        if (ListaDeComponentes[i].Name == "CerrarCircuito")
        {
            ImprimirCerrarCircuito(i);
        }

    }
}

void ImprimirVentanaParalela()
{
    for (int i = 0; Ventanas.Count > i; i++)
    {
        Console.SetCursorPosition(Ventanas[i].posVX ,0);
        Console.WriteLine($" {Ventanas[i].canalesDeVentana} - {Ventanas[i].nDeVentana} |");
    }
    
}

Double CalcularResitenciaTotal()
{
    Double RT = 0;
    for (int i = 0; ResistenciaTotalLista.Count > i; i++)
    {
        RT = ResistenciaTotalLista[i].Valor + RT; 
    }

    return RT;
}

Double CalcularIntenciad(Double VoltiosIniciales, Double ValorDeresistencia)
{
    if (ValorDeresistencia <= 0)
    {
        return 0;
    }
    else
    {
        Intensidad = VoltionIniciales / ValorDeresistencia;
        return Intensidad;
    }
    
}

int posVx = 0;
int nDeVentanas = 0;
Y = InitialPosY +1;
Double ValorDeReccistencia = 0;
Double ResistenciaTotal = 0;

while (true)
{
    ImprimirVentanaParalela();
    Console.SetCursorPosition(2, 5);
    Console.WriteLine($"RT = {ResistenciaTotal} ohm");
    ImprimirGrafico();

    ConsoleKeyInfo Key = Console.ReadKey(true);
    if ( Key.Key == ConsoleKey.C)
    {
        Intensidad = CalcularIntenciad(VoltionIniciales, ResistenciaTotal);
        ListaDeComponentes.Add(new Componentes { Name= "Cable", posX=60, posY = Y, Valor=Intensidad });
        Y = Y + 1;
    }

    if (Key.Key == ConsoleKey.R)
    {
        Console.WriteLine("Valor De la Recistencia");
        ValorDeReccistencia = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        ListaDeComponentes.Add(new Componentes { Name = "Resistencia", posX = 60, posY = Y, Valor = ValorDeReccistencia });
        ResistenciaTotalLista.Add(new Componentes { Name = "Resistencia", posX = 60, posY = Y, Valor = ValorDeReccistencia });

        ResistenciaTotal = CalcularResitenciaTotal();
        Y = Y + 1;
    }

    if (Key.Key == ConsoleKey.P)
    {
        Console.WriteLine("Cuantos Canales tiene la Resistencia Paralela");
        int Canales = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        ListaDeComponentes.Add(new Componentes { Name = "ResistenciaParalela", posX = 60, posY = Y, Valor = Canales });
        Ventanas.Add(new Ventanas { canalesDeVentana = Canales, nDeVentana = nDeVentanas, posVX = posVx }); 
        nDeVentanas++;
        posVx = +10;
        Y = Y + 1;

    }

    if (Key.Key == ConsoleKey.Escape)
    {
        ListaDeComponentes.Add(new Componentes { Name = "CerrarCircuito", posX = 60, posY = Y, Valor = 0});
        ImprimirGrafico();
        break;
    }
}

public class Ventanas
{
    public int nDeVentana { get; set; }

    public int canalesDeVentana {  set; get; }

    public int posVX { get; set; }

}
public class Componentes
{
    public string? Name { get; set; }

    public int posX { get; set; }

    public int posY { get; set; }

    public Double Valor { get; set; }

}