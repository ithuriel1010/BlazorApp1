using EFGetStarted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class SexInfo
    {
        public List<SexData> GetSexData()
        {
            List<Boolean> sex;

            List<SexData> data = new List<SexData>();

            using (var db = new BloggingContext())
            {
                sex = db.Respondent.Select(x => x.Sex).ToList();
            }

            var all = sex.Count();
            var distinct = sex.Distinct();

            foreach (var r in distinct)
            {
                string x;
                if(r==true)
                {
                    x = "Kobieta";
                }
                else
                {
                    x = "Mezczyzna";
                }
                data.Add(new SexData
                {
                    Name = x,
                    Value = sex.Count(x => x == r) * 100 / all
                });
            }
            return data;
        }

    }

    public class SexData
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
