using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pedir al usuario que ingrese una fecha y hora H:m:s
            System.Console.WriteLine("Escribe un fecha y hora dd/MM/YYYY  H:mm:s");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine(fecha.ToString());
            System.Console.WriteLine("");

            //A partir de la fecha actual, obtener la fecha "dentro de 2 horas y 30 minutos" y mostrarla
            System.Console.WriteLine("dentro de 2 horas y 30 minutos");
            DateTime fechaNow = DateTime.Now;
            System.Console.WriteLine(((fechaNow.AddHours(2)).AddMinutes(30)).ToString());
            System.Console.WriteLine("");


            //Mostrar la fecha y hora actual en horario UTC
            System.Console.WriteLine("Mostrar la fecha y hora actual en horario UTC");
            DateTime Utc = DateTime.UtcNow;
            System.Console.WriteLine(Utc.ToString());
            System.Console.WriteLine("");

            //Mostrar la fecha y hora actual en horario de otro país y mencionar el nombre del país
            System.Console.WriteLine("Mostrar la fecha y hora actual en horario de otro país y mencionar el nombre del país");
            DateTime thisTime = DateTime.Now;

            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");

            DateTime tstTime = TimeZoneInfo.ConvertTime(thisTime, TimeZoneInfo.Local, tst);

            System.Console.WriteLine(tst.StandardName + " " + tstTime);

            System.Console.WriteLine("");

            /* Comparar la fecha y hora actual con la fecha y hora ingresada. Si la fecha ingresada está en el futuro, 
               mostrar cuántos días faltan. Si la fecha ingresada está en el pasado, mostrar cuántos días han transcurrido.
               */
            System.Console.WriteLine("Comparar la fecha y hora actual con la fecha y hora ingresada.");

            if (fecha == fechaNow)
            {
                System.Console.WriteLine("Es la misma fecha");
            }

            else if (fecha < fechaNow)
            {

                TimeSpan tiempoDiferencia = fechaNow - fecha;
                System.Console.WriteLine("Han transcurrido " + tiempoDiferencia.Days + " días");

            }

            else
            {

                TimeSpan tiempoDiferencia = fecha - fechaNow;
                System.Console.WriteLine("Faltan " + tiempoDiferencia.Days + " días");

            }
        }
    }
}
