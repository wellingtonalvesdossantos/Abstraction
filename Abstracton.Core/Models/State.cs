namespace Abstraction.Core.Models
{
    public class State
    {
        public State() { }

        public State(string acronym, string name)
        {
            Acronym = acronym;
            Name = name;
        }

        public string? Acronym { get; set; }
        public string? Name { get; set; }

        public override string? ToString() => Acronym;
    }
}
