using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agus
{

    class Cuenta
    {
        public string titular;
        public double cantidad = 0;

        public Cuenta() { }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular()
        {
            return "Titular: " + titular;
        }

        public double Retirar(double nuevaCantidad)
        {
            this.cantidad = this.cantidad - nuevaCantidad;
            if (this.cantidad > 0)
            {
                return this.cantidad;
            }
            else {
                return this.cantidad = 0;
            }
        }

        public double MontoTotal(double monto)
        {
            this.cantidad = this.cantidad + monto;
            if (this.cantidad > 0)
            {
                return this.cantidad;
            }
            else
            {
                return this.cantidad = 0;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            Console.WriteLine("Ingresar el nombre del titular: ");
            cuenta.titular = Console.ReadLine();
            

            while (true) {
                Console.Clear();
                Console.WriteLine(cuenta.Titular());
                Console.WriteLine("1. Ver Monto total");
                Console.WriteLine("2. Ingresar Monto");
                Console.WriteLine("3. Retirar Monto");
                ConsoleKeyInfo tecla;
                double nuevaCantidad;
                double monto; 

                tecla = Console.ReadKey();


                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("El monto total es: " + cuenta.cantidad );
                    Console.ReadKey();

                }

                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.Write("Ingresar la cantidad de monto: ");
                    monto = Convert.ToDouble(Console.ReadLine());

                    if (monto > 0)
                    {
                        cuenta.MontoTotal(monto);
                    }

                }

                if (tecla.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.Write("Ingresar el monto a retirar: ");
                    nuevaCantidad= Convert.ToDouble(Console.ReadLine());

                    if (nuevaCantidad > 0 )
                    {
                        cuenta.Retirar(nuevaCantidad);
                    }
                    
                }

                Console.ReadKey();
            }
        }

            
    }
}
