using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.GUI
{
    public class Menu
    {
        public void menuPrincipal()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 10); Console.WriteLine("");
                Console.SetCursorPosition(10, 12); Console.WriteLine("1.Registrar Estudiante");
                Console.SetCursorPosition(10, 14); Console.WriteLine("2. Ver Valor de Impuesto del establecimiento ");
                Console.SetCursorPosition(10, 16); Console.WriteLine("3. Tarifa IVA");
                Console.SetCursorPosition(10, 18); Console.WriteLine("4. Salir");
                Console.SetCursorPosition(10, 19); Console.WriteLine("Digite una opción:");
                Console.SetCursorPosition(29, 19); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("DIGITE UNA OPCION VALIDA");
                        break;
                }

            } while (true);
        }
    }
}
