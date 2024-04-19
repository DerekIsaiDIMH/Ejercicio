namespace ExamenPractico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular la paga neta de un trabajador conociendo el número de horas trabajadas, la tarifa horaria
            //y la tasa de impuestos.

            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de pago por hora(Tarifa Horaria): ");
            double pagoxHora = Convert.ToDouble(Console.ReadLine());
            //double pagoxHora = 200.50;

            Console.Write("Ingrese la tasa de los impuestos (%): ");
            double tasaImpuestos = Convert.ToDouble(Console.ReadLine());
            //double tasaImpuestos = 17.02;

            double sueldo = horasTrabajadas * pagoxHora;

            double impuesto = sueldo * (tasaImpuestos / 100);

            double sueldoTotal = sueldo - impuesto;

            Console.WriteLine("Su sueldo sería: $"+ sueldoTotal);







        }
    }
}
