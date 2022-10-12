namespace ERS.Learn.Dotnet.Bogus.Domain
{
    public class Studant
    {
        public int Name { get; set; }
        public DateTime DateBorn { get; set; }
        public bool Enable { get; set; }
        public Guid RA { get; set; }

        public Studant()
        {
            RA = Guid.NewGuid();
        }
    }
}