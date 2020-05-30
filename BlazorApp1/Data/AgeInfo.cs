using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class AgeInfo    //Pobranie informacji o wieku w celu stworzenia wykresu
    {
        public List<AgeData> GetAgeData()
        {
            List<Boolean> group;

            List<AgeData> data = new List<AgeData>();

            using (var db = new BloggingContext())
            {
                group = db.Respondent.Select(x => x.Grupa).ToList();    //Zapisujemy wszystkich respondentów z bazy do listy
            }

            var all = group.Count();            //Wybieramy wartości danej "Grupa" dla respondentów
            var distinct = group.Distinct();    //Wybieramy wszystkie osoby z różnymi wartościami

            foreach (var r in distinct)
            {
                string x;
                if (r == true)
                {
                    x = "Osoby 50+";
                }
                else
                {
                    x = "Osoby młode";
                }
                data.Add(new AgeData
                {
                    Name = x,               //Wybieramy nazwę danego kawałka wykresu
                    Value = group.Count(x => x == r) * 100 / all    //Liczymy procent osób w danej grupie
                });
            }
            return data;
        }

    }

    public class AgeData
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
