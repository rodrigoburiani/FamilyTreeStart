using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Rodrigo", 33);
            Persona persona2 = new Persona("Clau", 34);
            Persona persona3 = new Persona("Tuny", 40);
            Persona persona4 = new Persona("Ale", 30);
            Persona persona5 = new Persona("Gaby", 29);
            Persona persona6 = new Persona("Dario", 25);
            Persona persona7 = new Persona("Rosa", 50);

            Node n1 = new Node(persona1);
            Node n2 = new Node(persona2);
            Node n3 = new Node(persona3);
            Node n4 = new Node(persona4);
            Node n5 = new Node(persona5);
            Node n6 = new Node(persona6);
            Node n7 = new Node(persona7);

            n1.AddChild(n2);
            n1.AddChild(n3);

            n2.AddChild(n4);
            n2.AddChild(n5);

            n3.AddChild(n6);
            n3.AddChild(n7);

// Visitar el árbol de la siguiente manera:
            AgeSumVisitor visitor = new AgeSumVisitor();
            n1.Accept(visitor);
            int ageSum = visitor.GetAgeSum();

            Console.WriteLine("La suma de las edades de todos los integrantes de la familia es: " + ageSum);
            
            LargestChildVisitor largestChildVisitor = new LargestChildVisitor();
            n1.Accept(largestChildVisitor);
            Node largestChild = largestChildVisitor.GetLargestChild();
            if (largestChild != null)
            {
                Console.WriteLine("El hijo más grande es: " + largestChild.Persona.Nombre);
            }

            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            n1.Accept(longestNameVisitor);
            string longestName = longestNameVisitor.GetLongestName();
            if (!string.IsNullOrEmpty(longestName))
            {
                Console.WriteLine("La persona con el nombre más largo es: " + longestName);
            }
        }
    }
}
