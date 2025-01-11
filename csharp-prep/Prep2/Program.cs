using System;
using System.Reflection.Metadata;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        bool preguntar = true;
        while (preguntar)
        {

            Console.Write("Ingrese una calificación: ");
            int calificacion;
            while (!int.TryParse(Console.ReadLine(), out calificacion) || (calificacion > 100))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                Console.Write("Ingrese una calificación: ");
            }



            if (calificacion >= 90)
            {
                Console.WriteLine($"Su Calificación para {calificacion}  es: A");
            }
            else if (calificacion >= 80)
            {
                Console.WriteLine($"Su Calificación para {calificacion}  es: B");
            }
            else if (calificacion >= 70)
            {
                Console.WriteLine($"Su Calificación para {calificacion}  es: C");
            }
            else if (calificacion >= 60)
            {
                Console.WriteLine($"Su Calificación para {calificacion}  es: D");
            }
            else
            {
                Console.WriteLine($"Su Calificación para {calificacion}  es: F");
            }


            bool valor = true;
            while (valor)
            {
                Console.Write("Quieres seguir ingresando notas elige entre el uno o el cero:\nsi = 1\nno = 0\n\nSu elección es: ");
                int elecion;
                if (int.TryParse(Console.ReadLine(), out elecion) && (elecion == 1 || elecion == 0))
                {
                    if (elecion == 1)
                    {
                        valor = false;
                    }
                    else
                    {
                        preguntar = false;
                        valor = false;
                    }

                }
                else
                {
                    Console.WriteLine("Ingresaste un valor incorrecto");
                }
            }
        }
    }
}