// Simular un menú que se repita hasta que el usuario elija salir.
int opcion = 0;
while (opcion != 3)
{
    Console.WriteLine("1) Saludar");
    Console.WriteLine("2) Mostrar mensaje");
    Console.WriteLine("3) Salir");
    Console.Write("Opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Buenos días usuario!!");
            break;
        case 2:
            Console.WriteLine("Espero tengas muy lindo día!!");
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion invalida..");
            break;
    }
    Console.WriteLine();
}
Console.WriteLine("Programa finalizado.");
