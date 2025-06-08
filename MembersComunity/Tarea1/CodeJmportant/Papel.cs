using System;


internal class Papel
{
    internal class Estudiante : MiembroComunidad
    {
        public string Carrera { get; set; }
        public string Horario { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Horario: {Horario}");
        }
    }

    internal class ExAlumno : MiembroComunidad
    {
        public int Añoingreso { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Año de ingreso: {Añoingreso}");
        }
    }

    internal abstract class Empleado : MiembroComunidad
    {
        public string Departamento { get; set; }
        public string Horario { get; set; }
    }

    internal class Administrativo : Empleado
    {
        public string Puesto { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    internal abstract class Docente : Empleado
    {
        public bool DentroSistema { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Dentro del Sistema: {DentroSistema}");
        }
    }
    internal class Maestro : Docente
    {
        public string Materia { get; set; }
        public string CursoAsignado { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Materia: {Materia}");
            Console.WriteLine($"Curso Asignado: {CursoAsignado}");
            Console.WriteLine();
        }
    }

    internal class Administrador : Docente
    {
        public string AreaAdministrativa { get; set; }

        public override void ShowInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
            Console.WriteLine();
        }
    }
}