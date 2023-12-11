//Controlador
class EmpleadoController
{
    private EmpleadoModel modelo;
    private EmpleadoView vista;

    public EmpleadoController(EmpleadoModel modelo, EmpleadoView vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }

    public void SetNombre(string nombre)
    {
        modelo.Nombre = nombre;
    }

    public void SetEdad(int edad)
    {
        modelo.Edad = edad;
    }

    public void SetCargo(string cargo)
    {
        modelo.Cargo = cargo;
    }

    public void SetSalario(double Salario)
    {
        modelo.Salario = Salario;
    }

    public void ActualizarVista()
    {
        vista.MostrarDetallesEmpleado(modelo);
    }
}