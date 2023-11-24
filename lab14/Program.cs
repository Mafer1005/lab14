using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Interfaz.Menu();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Interfaz.EncuestaVacuna();
                        break;
                    case 2:
                        opcion = Interfaz.DatosDeLaEncuesta();
                        break;
                    case 3:
                        opcion = Interfaz.ResultadosFinales();
                        break;
                    case 4:
                        opcion = Interfaz.BuscarGente();
                        break;
                    case 0:
                    default:
                        opcion = Interfaz.Menu();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
