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
                       
        static void Main()
        {
            
        }
    }
}