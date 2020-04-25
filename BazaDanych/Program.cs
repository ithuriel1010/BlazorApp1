using System;
using System.Linq;

namespace EFGetStarted
{
    public class Program
    {
        public void CreateRespondent(Respondent respondent)
        {
            using (var db = new BloggingContext())
            {
                db.Add(respondent);
                db.SaveChanges();
            }                
        }

        public void GetData()
        {
            using (var db = new BloggingContext())
            {
                var wykszt = db.Respondent.Select(x => x.Wyksztalcenie).ToList();
            }
        }

        
        static void Main()
        {
            
        }
    }
}