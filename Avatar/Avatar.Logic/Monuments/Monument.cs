namespace Avatar.Logic.Monuments
{
    public abstract class Monument
    {
        public string Name { get; }

        protected Monument(string name) =>
            this.Name = name;

        public override string ToString()
        {
            var monumentTypeName = this.GetType().Name
                .Replace(nameof(Monument), string.Empty);

            return $"{monumentTypeName} Monument: {this.Name}, {this.ToMonumentString()}";
        }

        public abstract uint CalculateNationPowerIncrease();

        protected abstract string ToMonumentString();
    }
}
