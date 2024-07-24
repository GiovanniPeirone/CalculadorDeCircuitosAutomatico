from pynput import keyboard 
from os import system
from Menus import Menu_1

def on_press(key):
    try:
        print('alphanumeric key {0} pressed'.format(
            key.char))
    except AttributeError:
        print('special key {0} pressed'.format(
            key))

def on_release(key):
    print('{0} released'.format(
        key))
    if key == keyboard.Key.esc:
        # Stop listener
        return False

# Collect events until released
with keyboard.Listener(
        on_press=on_press,
        on_release=on_release) as listener:
    listener.join()

# ...or, in a non-blocking fashion:
listener = keyboard.Listener(
    on_press=on_press,
    on_release=on_release
)


opcion = Menu_1.MenuInicial()
while opcion:
    try:
        
        print("hola")
        
        system("cls")
    except ValueError:
        opcion = Menu_1.MenuInicial()
