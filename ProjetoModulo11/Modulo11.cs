namespace Datas
{
    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2024, 07, 11, 11, 01, 30);
            var date2 = DateTime.Parse("2024/07/11 11:01:30");
            var date3 = DateTime.Now; //--> Puxa a Data e Hora atual
            var date4 = DateTime.Today; //--> Puxa a Data atual

            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);
            //Console.WriteLine(date4);

            Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));


            var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dateOffset1.LocalDateTime);
            Console.WriteLine(dateOffset1.UtcDateTime);

        }

        public void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2003-11-07");

            var diff = date1 - date2;
            Console.WriteLine(diff.TotalDays);
            Console.WriteLine(diff.TotalHours);
        }

        public void AulaAdcionandoDiaMesAno()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yy HH:mm:ss")); //Add 3 dias
            Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yy HH:mm:ss")); //add 1 mes
            Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yy HH:mm:ss")); //Add 2 anos

        }

        public void AulaAdcionandoHoraMinutoSegundo()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.AddHours(3).ToString("HH:mm:ss")); //Add 3 Horas
            Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss")); //add 10 Minutos
            Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss")); //Add 10 Segundos
        }

        public void AulaDiaDaSemana()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.DayOfWeek);
        }

        public void AulaDateOnly()
        {
            // var somenteData = new DateOnly(2024,07,2);
            var somenteData = DateOnly.Parse("2024-02-01");

            Console.WriteLine(somenteData);
        }

        public void AulaTimeOnly()
        {
            //var somenteHora = new TimeOnly(18,50,59);
            var somenteHora = TimeOnly.Parse("18:50:59");

            Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
        }
    }
}
