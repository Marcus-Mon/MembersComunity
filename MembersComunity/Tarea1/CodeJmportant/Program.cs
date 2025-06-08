using System
namespace MembersComunity.Tarea1.CodeImportant
{
    class program
    {
        static void Main(string[] args)
        {
            // Estudiante
            var estudiante1 = new Papel.Estudiante
            {
                Nombre = "Marcus Montilla",
                Edad = 20,
                Correo = "20241783@itla.edu.do",
                Id = 20241783,
                Carrera = "Desarrollo de Software",
                Horario = "Vespertino",
            };

            // Rol ExAlumno
            var exAlumno1 = new Papel.ExAlumno
            {
                Nombre = "Clara Mortes",
                Edad = 25,
                Correo = "20231250@itla.edu.do",
                Id = 20231250,
                AñoIngreso = 2023
            };

           // Papel Administrativo
            var administrativo1 = new Papel.Administrativo
            {
                Nombre = "Jack Stanford",
                Edad = 43,
                Id = 123456098,
                Correo = "JackStford@persona.com",
                Departamento = "Tecnico",
                Horario = "8:00 AM - 3:00 PM",
                Cargo = "SubPersonal"
            };

            // Papel Maestro
            var maestro1 = new Papel.Maestro
            {
                Nombre = "Tulio Mendez",
                Edad = 35,
                ID = 20001234,
                CorreoInstitucional = "Tmendez@itla.edu.do",
                Departamento = "Educación",
                Horario = "Martes: 8:00am - 12:00pm",
                Materia = "Matematica 3",
                CursoAsignado = "SeccionLun",
                AccesoAlSistema = false
            };

            // Papel Administrador
            var administrador1 = new Papel.Administrador
            {
                Nombre = "Chen Jori-Katsu",
                Edad = 55,
                Correo = "Cjori@soyadmin.com",
                Id = 1235098,
                Departamento = "Administración",
                Horario = "8:00 AM - 5:00 PM",
                DentroSistema = true,
                AreaAdministrativa = "Gestion"
            };

            //mostrar la info
            estudiante1.MostrarInfo();
            exAlumno1.MostrarInfo();
            administrativo1.MostrarInfo();
            maestro1.MostrarInfo();
            administrador1.MostrarInfo();


            Console.ReadLine();
        }
    }
}
    }
}
