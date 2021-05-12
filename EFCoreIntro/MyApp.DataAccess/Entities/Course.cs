using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.Entities
{
    public class Course
    {

        //Id, ID, id wird als Konvetion für den PK angesehen
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
