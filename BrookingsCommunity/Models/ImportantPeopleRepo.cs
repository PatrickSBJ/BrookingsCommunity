using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class ImportantPeopleRepo
    {
        private static List<ImportantPerson> people = new List<ImportantPerson>();

        public static List<ImportantPerson> People { get { return people; } }
        public static void AddImportantPerson(ImportantPerson person)
        {
            people.Add(person);
        }
    }
}
