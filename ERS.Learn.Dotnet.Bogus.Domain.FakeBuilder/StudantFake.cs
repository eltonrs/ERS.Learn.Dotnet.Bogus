using Bogus;

namespace ERS.Learn.Dotnet.Bogus.Domain.FakeBuilder
{
    public class StudantFake
    {
        private readonly Faker<Studant> _faker;

        public StudantFake(string language = "pt_BR")
        {
            _faker = new Faker<Studant>(language);

            _faker.RuleFor(x => x.Name, f => f.Name.FullName());
            _faker.RuleFor(x => x.BirthDate, f => f.Date.Past(18));
            _faker.RuleFor(x => x.Enable, f => f.Random.Bool());
            _faker.RuleFor(x => x.RA, f => f.Random.Guid());
        }

        public StudantFake WithName(string newName)
        {
            _faker.RuleFor(x => x.Name, f => newName);

            return this;
        }

        public StudantFake WithBirthDate(DateTime newBirthDate)
        {
            _faker.RuleFor(x => x.BirthDate, newBirthDate);

            return this;
        }

        public StudantFake WithEnableb(bool newEnable)
        {
            _faker.RuleFor(x => x.Enable, newEnable);

            return this;
        }

        public StudantFake WithRA(Guid newRA)
        {
            _faker.RuleFor(x => x.RA, newRA);

            return this;
        }

        public Studant Generate() => _faker.Generate();
    }
}