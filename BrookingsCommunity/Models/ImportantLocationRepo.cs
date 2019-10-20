using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class ImportantLocationRepo
    {
        private static List<ImportantLocation> locations = new List<ImportantLocation>();

        public static List<ImportantLocation> Locations { get { return locations; } }
        public static void AddLocation(ImportantLocation location)
        {
            locations.Add(location);
        }
    }
}
