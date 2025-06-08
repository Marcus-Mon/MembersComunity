using System;
//Marcus Montilla

public class MiembroComunidad : Persona
{
    public string PapelComunidad { get; set; }

    public virtual void ShowInfo()
    {
        Console.WriteLine(" <Eres miembro de la comunidad>  ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Correo: {Correo}");
        Console.WriteLine($"Id: {Id}");
    }
}
