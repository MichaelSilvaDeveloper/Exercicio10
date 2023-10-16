using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado }
        static void Main(string[] args)
        {
            //DiasSemana ds = DiasSemana.Domingo;
            int ds = (int)DiasSemana.Sexta;
            Console.WriteLine(ds);
        }
    }
}
