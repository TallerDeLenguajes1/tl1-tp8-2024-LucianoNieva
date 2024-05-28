using tareas;


Console.WriteLine("1 crear Tarea Pendiente");
Console.WriteLine("2 pasar tarea a realizada");
Console.WriteLine("3 mostrar tareas pendientes");
Console.WriteLine("4 mostrar tareas por descripcion");
string opciones = Console.ReadLine();
bool anda = int.TryParse(opciones, out int op);

var ListaPendiente = new List<Tarea>();
var ListaRealizados = new List<Tarea>();
Tarea tareaAmover = null;
while (op != 0)
{
    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese el id de la tarea");
            string id = Console.ReadLine();
            int.TryParse(id, out int ID);

            Console.WriteLine("Ingrese la descripcion");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese la duracion");
            string duracion = Console.ReadLine();
            int.TryParse(duracion, out int DURACION);

            var tarea = new Tarea(ID, descripcion, DURACION);
            ListaPendiente.Add(tarea);
            break;

        case 2:
            Console.WriteLine("Ingrese el id que desea buscar");
            string id2 = Console.ReadLine();
            int.TryParse(id2, out int ID2);


            foreach (var listaPendiente in ListaPendiente)
            {
                if (listaPendiente.Id == ID2)
                {
                    tareaAmover = listaPendiente;
                    break;
                }
            }
            ListaRealizados.Add(tareaAmover);
            ListaPendiente.Remove(tareaAmover);
            break;

        case 3:
            foreach (var tareasMostrar in ListaPendiente)
            {
                Console.WriteLine($"El id de la tarea es: {tareasMostrar.Id}");
                Console.WriteLine($"La descripcion de la tarea es: {tareasMostrar.Descripcion}");
                Console.WriteLine($"La duracion de la tarea es: {tareasMostrar.Duracion}");
            }
            break;

        case 4:
            Console.WriteLine("Ingrese la descripcion que desea mostrar");
            string buscar = Console.ReadLine();

            foreach (var tareaBuscar in ListaRealizados)
            {
                if (tareaBuscar.Descripcion.Contains(buscar))
                {
                    Console.WriteLine($"El id de la tarea es: {tareaBuscar.Id}");
                    Console.WriteLine($"La descripcion de la tarea es: {tareaBuscar.Descripcion}");
                    Console.WriteLine($"La duracion de la tarea es: {tareaBuscar.Duracion}");
                }
            }

            foreach (var tareaBuscar in ListaPendiente)
            {
                if (tareaBuscar.Descripcion.Contains(buscar))
                {
                    Console.WriteLine($"El id de la tarea es: {tareaBuscar.Id}");
                    Console.WriteLine($"La descripcion de la tarea es: {tareaBuscar.Descripcion}");
                    Console.WriteLine($"La duracion de la tarea es: {tareaBuscar.Duracion}");
                }
            }
            break;
    }

    Console.WriteLine("1 crear Tarea Pendiente");
    Console.WriteLine("2 pasar tarea a realizada");
    Console.WriteLine("3 mostrar tareas pendientes");
    opciones = Console.ReadLine();
    int.TryParse(opciones, out op);


}



