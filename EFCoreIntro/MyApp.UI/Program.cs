using MyApp.DataAccess;
using MyApp.DataAccess.Entities;
using System;

namespace MyApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Max",
                    Birthday = new DateTime(2001, 2, 2),
                    Notendurschnitt = 3.4f
                };

                context.Students.Add(std);
                context.Add(std);


                //context.Database.BeginTransaction();
                //context.Database.CommitTransaction();
                //context.Database.RollbackTransaction();
                

                context.SaveChanges(); //Hier wird erst das SQL richtig DB gesendet
            }
        }
    }
}
