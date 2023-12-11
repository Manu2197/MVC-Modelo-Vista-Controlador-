//Vista
class EmpleadoView
{
    public void MostrarDetallesEmpleado(EmpleadoModel empleado)
    {
        Console.WriteLine($"Nombre: {empleado.Nombre}, Edad: {empleado.Edad}, Cargo: {empleado.Cargo}, Salario: {empleado.Salario}");
    }
    
}