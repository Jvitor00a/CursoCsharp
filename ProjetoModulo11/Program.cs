using System;
using Datas;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComDatas();
        }

        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Datas.TrabalhandoComDatas();
            trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdcionandoDiaMesAno();
            //trabalhandoComDatas.AulaAdcionandoHoraMinutoSegundo();
            //trabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly(); 
            //trabalhandoComDatas.AulaTimeOnly(); 
        }


    }
}