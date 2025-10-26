using System

namespace ProgramaRoto
{
    class Calculo
    {
        public int numero1;
        public string numero2;
        public double resultado

        public void Sumar()
        {
            resultado = numero1 + numero2; 
            Console.WriteLine("Resultado: " + resultado)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Consola.WriteLine("=== PROGRAMA ===") 
            Calculo calc = nuevo Calculo() 
            calc.numero1 = "10"; 
            calc.numero2 = 5; 

            calc.Sumar()

            Console.WriteLine("Ingrese su nombre: ")
            string nombre;
            Console.WriteLine("Hola, " + nombre) 

            si(calc.resultado > 10) 
            {
                Console.WriteLine("El resultado es mayor a 10")
            }
            sino 
            {
                Console.WriteLine("El resultado es menor o igual a 10")
            }

            MostrarMensaje() 
        }

        static void MostrarMensajes() 
        {
            Console.WriteLine("Esto jamás se mostrará")
        }
    }
}