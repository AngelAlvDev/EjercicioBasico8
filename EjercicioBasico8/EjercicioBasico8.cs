using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico8
{
    class EjercicioBasico8
    {
        static void Main(string[] args)
        {
            Int16 mes;
            Int16 year;
            Int16 dias;
            Console.WriteLine("Introduzca fecha según el formato indicado:");
            do
            {
                Console.Write("Mes(##): ");
                mes = Convert.ToInt16(Console.ReadLine());
            } while (mes < 1 || mes > 12);
            do
            {
                Console.Write("Año(####): ");
                year = Convert.ToInt16(Console.ReadLine());

            } while (year < 0000 || year > 9999);
            

            switch(mes){
                case 2:
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                            {
                                dias = 29;
                            }
                            else
                                dias = 28;
                        }
                        else
                            dias = 28;
                    }
                    else
                        dias = 28;
                    break;
                case 4:
                    dias = 30;
                    break;
                case 6:
                    dias = 30;
                    break;
                case 9:
                    dias = 30;
                    break;
                case 11:
                    dias = 30;
                    break;
                default:
                    dias = 31;
                    break;
            }
            Console.WriteLine("El mes " + mes + " del año " + year + " tiene " + dias + " días.");
            Console.ReadLine();
        }
    }
}
