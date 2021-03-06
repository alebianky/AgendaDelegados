using System;
using System.Collections.Generic;

namespace Demo20.Herencia {    
    public record Contacto(string Nombre, int Telefono);

    public class Agenda {
        List<Contacto> contactos = new();

        public void Agregar(Contacto c) => contactos.Add(c);

        public void Listar(){
            Console.WriteLine($"> Contactos");
            foreach(var c in contactos) 
                Mostrar(c);
            Console.WriteLine();
        }

        protected virtual void Mostrar(Contacto c) =>  Console.WriteLine($"  - {c.Nombre,-20} >> {c.Telefono} ");
    }

    public class AgendaInvertida: Agenda {
        protected override void Mostrar(Contacto c) =>  Console.WriteLine($"  - {c.Telefono,-20} << {c.Nombre}");
    }

    public class Programa {
        public static void Probar() {
            var agenda = new Agenda();
            // var agenda = new AgendaInvertida();
            agenda.Agregar( new("Alejandro", 456_7890) );
            agenda.Agregar( new("Alvaro",    456_7891) );
            agenda.Agregar( new("Franco",    456_7892) );
            agenda.Agregar( new("Hugo",      456_7893) );
            agenda.Agregar( new("Nahuel",    456_7894) );
            
            Console.Clear();
            Console.WriteLine("Demo Open/Close (Usando Herencia)");

            Console.WriteLine("\nEjemplo 1");
            agenda.Listar();
        }
    }
}