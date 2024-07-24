
def MenuInicial():

    Menuinicial = """
    /
    /                         1 - Comenzar
    /                         2 - Salir
    /
    """
    
    print(Menuinicial)

    opcion = int(input("seleccione un opcion"))
    if opcion <= 1:
        return True
    elif opcion >= 2:
        return False