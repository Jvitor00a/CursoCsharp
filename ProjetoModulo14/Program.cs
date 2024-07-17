using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TrabalhandoComLinq();
        }

        private static void TrabalhandoComLinq()
        {
            var linq = new LinQ.TrabalhandoComLinq();
            //linq.AulaWhere();
            //linq.AulaOrdenacao();
            //linq.AulaTake();
            //linq.AulaCount();
            linq.AulaFirstEFirstOrDefault();
        }
    }
}
