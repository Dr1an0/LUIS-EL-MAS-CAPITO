using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoPago, tipoTarjeta, dia;
            int cantidad;
            double recargo, descuento, montoInicial, precio, montoFinal;

            recargo = 0;
            descuento = 0;
            montoInicial = 0;

            Console.Write("\nINGRESE LA CANTIDAD DE PRODUCTOS: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nINGRESE EL PRECIO UNITARIO: ");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nINGRESE EL TIPO DE PAGO: ");
            tipoPago = Console.ReadLine().ToUpper();

            montoInicial = cantidad * precio;

            switch (tipoPago)
            {
                case "EFECTIVO":
                    if (cantidad > 3)
                    {
                        descuento = montoInicial * 0.10;
                    }
                    break;

                case "TARJETA":
                    Console.Write("Ingrese el tipo de tarjeta (DÉBITO / CRÉDITO): ");
                    tipoTarjeta = Console.ReadLine().ToUpper();

                    if (tipoTarjeta == "DÉBITO" && montoInicial > 150)
                    {
                        descuento = montoInicial * 0.08;
                    }
                    else if (tipoTarjeta == "CRÉDITO")
                    {
                        recargo = montoInicial * 0.04;
                    }
                    break;

                case "BILLETERA DIGITAL":
                    Console.Write("Ingrese el día de la semana actual: ");
                    dia = Console.ReadLine().ToUpper();

                    if (dia == "LUNES" || dia == "MARTES")
                    {
                        descuento = 15; // descuento fijo
                    }
                    break;

                default:
                    Console.WriteLine("TIPO DE PAGO INVÁLIDO");
                    break;
            }

            montoFinal = montoInicial - descuento + recargo;

            Console.WriteLine("MONTO INICIAL: " + montoInicial);

            if (descuento > 0)
            {
                Console.WriteLine("OPERACIÓN APLICADA: DESCUENTO " + descuento);
            }
            else
            {
                Console.WriteLine("OPERACIÓN APLICADA: RECARGO " + recargo);
            }

            Console.WriteLine("MONTO FINAL A PAGAR: " + montoFinal);

        }
    }
}
