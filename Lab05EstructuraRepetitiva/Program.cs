using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05EstructuraRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoge la operacion que quieras hacer: "+
                "\n1: El ejercicio 01 "+
                "\n2: El ejercicio 02 "+
                "\n3: El ejercicio 03 "+
                "\n4: El ejercicio 04 ");
            int opciones=int.Parse(Console.ReadLine());

            switch (opciones) {
                case 1:
                    ejercicio01();    
                    break;
                
                case 2:

                    ejercicio02();
                    break;


                case 3:

                    ejercicio03();
                    break;


                case 4:

                    ejercicio04();
                    break;

                default:
                    Console.WriteLine("Escoja una de las  opciones.");
                    break;
            }

        }

        static void ejercicio01() {
            //Multiplicacion sin usar el "por"
            Console.Write("Ingrese el numero 1: ");
            int num1 =int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero 2: ");
            int num2=int.Parse(Console.ReadLine());
            int producto = 0;
            for (int i = 1; i<= num2 ; i++)
            {
                producto = producto + num1;

               
            }
            Console.WriteLine("El producto es : "+ producto);



            Console.ReadKey();
        }

        static void ejercicio02() {
            //Potenciacion
            Console.Write("Ingrese la base : ");
            int bs= int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponente= int.Parse(Console.ReadLine());
            int potencia = 1;
            for (int i = 0; i < exponente; i++)
            {
                    
                potencia = potencia * bs;
           
            }
            Console.WriteLine("El resultado es: "+ potencia);
            Console.ReadKey();
        
        
        }

        static void ejercicio03() {
            Console.Write("Ingrese el numero de notas: ");
            int notas = int.Parse(Console.ReadLine());
            float nota = 0;
            float promedio = 0f;
            for (int i = 1; i <= notas; i++)
            {
                Console.Write("Ingrese el número " + i + ": ");
                int num = int.Parse(Console.ReadLine());
                nota = nota + num;

            }
            promedio = nota / notas;

            Console.WriteLine(" El promedio es : " + promedio);
            Console.ReadLine();



        }
        static void ejercicio04() {
            Console.Write("Ingrese el numero limite: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Escoge una de las opciones: " +
               "\n 1: Lista de numeros pares" +
               "\n 2: Lista de numeros impares" +
               "\n 3: Lista de el factorial");
            int opcion=int.Parse(Console.ReadLine());
            long factorial = 1;
            Console.WriteLine("============================");
            switch (opcion)
            {
                case 1:
                    Console.Write("La respuesta es ");
                    for (int i = 2; i < limite; i+=2) {

                        Console.Write(", " + i);
                    }
                    break;
                case 2:
                    Console.Write("La respuesta es ");
                    for (int i = 1; i < limite; i += 2)
                    {

                        Console.Write(", " + i);
                    }
                    break;
                case 3:
                    for (int i = 1;i<=limite;i++) {
                        factorial=factorial*i;
                    
                    }
                    Console.WriteLine("El factorial es: "+ factorial);
                    break;  

                default:
                    break;
            }




            Console.ReadKey();
        }
    }
}
