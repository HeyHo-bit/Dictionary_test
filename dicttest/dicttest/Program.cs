using System.Collections.Generic;
using System.Linq;

namespace dicttest
{
    internal class Program
    {
        enum Felveteli_Pont
        {
            f101t102,
            f102t103,
            f103t104,
            f104t105,
            f105t106,
            f106t107,
            f107t108,
            f108t109,
            f110t111,
            f112t113,
            f113t114,
            f114t115,
        }



        static void Main(string[] args)
        {

            var dict = new Dictionary<Felveteli_Pont, DateTime>();
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();

                DateTime StartDate = new(2019, 09, 10, 08, 00, r.Next(0, 60));
                DateTime EndDate = new(2019, 09, 10, 08, 00, r.Next(0, 60));

                long elapsedTicks = EndDate.Ticks - StartDate.Ticks;
                var localDate2 = DateTime.FromBinary(elapsedTicks);

                dict.Add((Felveteli_Pont)i,localDate2 );
            }


            foreach (KeyValuePair<Felveteli_Pont, DateTime> ele in dict)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value.ToString("HH:mm:ss"));
            }
            var averageScore = dict.Values.Average(d => d.Second);
           Console.WriteLine(averageScore);
        }
    }
}