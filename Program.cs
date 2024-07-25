// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CalcularCircuito;

Console.CursorVisible = false;

void CrearBateria()
{
    string bateria = """
        █
    ▄▄▄▄█▄▄▄▄
      ▄▄▄▄▄
        █
    """;
    Console.SetCursorPosition(5,30);
    Console.WriteLine(bateria); 
}

while (true)
{
    Console.Clear();
    CrearBateria();
    Thread.Sleep(10);
}
