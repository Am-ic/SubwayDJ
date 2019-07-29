using Subway.Data;
using Subway.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Subway.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Population> list = PopulationConveter.Instance.Convert(@"Z:\D\sync\402W\DevexpressPractice\Subway (조기현 차용우 황수창)\CsvToTable\subway.csv");

            System.Console.WriteLine(list.Count);

            //List<string> stations = DataRepository.Daejeon.GetStationNames();
            //List<Daejeon> list = DataRepository.Daejeon.GetAll();
            //var l = DataRepository.Daejeon.GetPassengers();
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
