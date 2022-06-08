namespace API.Helpers;
public class Autorizacion //Sirve para tipar el Rol que tendrá en usuaruio
{
    public enum Roles
    {
        Administrador,
        Gerente,
        Empleado
    }

    public const Roles rol_predeterminado = Roles.Empleado;
}
