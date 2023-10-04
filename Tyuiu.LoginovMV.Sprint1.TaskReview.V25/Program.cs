using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint1.TaskReview.V25.Lib;

namespace Tyuiu.LoginovMV.Sprint1.TaskReview.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            var res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
