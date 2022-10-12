using System.Xml.Linq;

namespace ERS.Learn.Dotnet.Bogus.Domain
{
    public class Studant
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Enable { get; set; }
        public Guid RA { get; set; }

        public Studant()
        {
            Name = string.Empty;
            RA = Guid.NewGuid();
        }
    }
}