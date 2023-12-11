internal class Program
{
    private static void Main(string[] args)
    {
        // Crear instancias del modelo, la vista y el controlador
        EmpleadoModel empleado = new EmpleadoModel();
        EmpleadoView vista = new EmpleadoView();
        EmpleadoController controlador = new EmpleadoController(empleado, vista);

        // Actualizar el modelo a través del controlador
        controlador.SetNombre("Juan");
        controlador.SetEdad(30);
        controlador.SetCargo("Auxiliar");
        controlador.SetSalario(450.90);

        // Mostrar los detalles del empleado a través de la vista
        controlador.ActualizarVista();

        // Modificar el modelo nuevamente y actualizar la vista
        controlador.SetEdad(31);
        controlador.SetCargo("Gerente");
        controlador.ActualizarVista();        
    }
}