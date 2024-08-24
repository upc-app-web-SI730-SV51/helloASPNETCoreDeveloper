namespace helloASPNETCoreDeveloper.Generic.Domain.Model.Entities;

public class WelcomeBuilder
{
    public static string Builder(string? name) // existe la posibilidad de que el parametro puede ser numero
    {
        return name == null ? "Welcome!" : $"Welcome {name}!"; // si es null o entra un nombre (string)
    }
}