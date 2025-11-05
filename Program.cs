using system; // (1) 'System' mal escrito
using System.Collections; // (2) debería usarse Generic

namespace ProgramaRotoCompacto
{
    class Usuario
    {
        public string nombre;
        public int edad;
        public double saldo;

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombres); // (3) variable mal escrita
            Console.WriteLine("Edad: " + Edad); // (4) mayúscula incorrecta
            Console.WriteLine("Saldo: $" + saldo + "0"); // (5) agrega 0 siempre
        }

        public void CumplirAnios()
        {
            edad = edad + "1"; // (6) suma string a int
        }
    }

    class Banco
    {
        public List<double> transacciones; // (7) falta using correcto
        public double promedio;
        public bool tieneDeudas;

        public void CalcularPromedio()
        {
            double suma = 0;
            for (int i = 1; i <= transacciones.Count; i++) // (8) se salta índice 0
                suma += transacciones[i]; // (9) error de índice

            promedio = suma / transacciones.Count;
            tieneDeudas = promedio > "1000"; // (10) compara double con string
        }

        public void MostrarResumen()
        {
            Console.WriteLine("Promedio: " + promedios); // (11) mal escrita
            Console.WriteLine("Tiene deudas: " + tieneDeuda); // (12) nombre distinto
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Consola.WriteLine("=== BANCO ROTO ==="); // (13) Consola mal escrita
            Usuario u = nuevo Usuario(); // (14) 'nuevo' en vez de 'new'
            u.nombre = 123; // (15) int a string
            u.edad = "30"; // (16) string a int
            u.saldo = 500,25; // (17) coma decimal incorrecta
            u.CumplirAnios();
            u.Mostrar();

            Banco b = new Banco();
            b.transacciones = new List<double>();
            b.transacciones.Add("100"); // (18) string a double
            b.transacciones.Add(200);
            b.transacciones.Add(-50.5);

            b.CalcularPromedio();
            b.MostrarResumen();

            Console.WriteLine("Ingrese monto para retirar:");
            string entrada = Console.ReadLine();
            double monto = Convert.ToInt32(entrada) / 0; // (19) división por cero
            if (monto = 100) // (20) asignación en condición
                Console.WriteLine("Monto igual a 100");
            else if (monto > "50") // (21) compara double con string
                Console.WriteLine("Monto grande");
            sino // (22) palabra reservada inexistente
                Console.WriteLine("Monto pequeño");

            for (int i = 0; i <= 2; i++) ; // (23) punto y coma extra
            {
                Console.WriteLine("Iteración " + i); // (24) i fuera de alcance
            }

            MostrarMensaje() // (25) falta punto y coma + método no definido
            Console.WriteLine("Fin del programa roto") // (26) falta punto y coma
        }
    }
}