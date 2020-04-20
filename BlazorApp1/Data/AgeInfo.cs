using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class AgeInfo
    {
        public List<AgeData> GetAgeData()
        {
            List<Boolean> group;

            List<AgeData> data = new List<AgeData>();

            using (var db = new BloggingContext())
            {
                group = db.Respondent.Select(x => x.Grupa).ToList();
            }

            var all = group.Count();
            var distinct = group.Distinct();

            foreach (var r in distinct)
            {
                string x;
                if (r == true)
                {
                    x = "Osoby 50+";
                }
                else
                {
                    x = "Osoby mode";
                }
                data.Add(new AgeData
                {
                    Name = x,
                    Value = group.Count(x => x == r) * 100 / all
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
