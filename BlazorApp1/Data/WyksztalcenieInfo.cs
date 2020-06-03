using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class WyksztalcenieInfo
    {
           
        public List<ChartData> GetData()    //Pobranie informacji o wykształceniu w celu stworzenia wykresu - wszystko zachodzi analogicznie jak w klasie AgeInfo
        {
            List<String> wykszt;

            List<ChartData> data = new List<ChartData>();

            using (var db = new BloggingContext())
            {
                wykszt = db.Respondent.Select(x => x.Wyksztalcenie).ToList();
            }

            var all = wykszt.Count();
            var distinct = wykszt.Distinct();

            foreach(var r in distinct)
            {
                data.Add(new ChartData
                {
                    Name = r,
                    Value = wykszt.Count(x => x == r)*100 / all
                });
            }
            return data;
        }

    }

    public class ChartData
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
