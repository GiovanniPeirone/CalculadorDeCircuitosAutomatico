from pynput import keyboard as kb
from os import system
from Menus import Menu_1

opcion = Menu_1.MenuInicial()

while opcion:
    try:
        print("hola")
    except ValueError:
        print("Error")