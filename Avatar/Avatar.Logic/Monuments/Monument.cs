using Avatar.Logic.Common.Extensions;

namespace Avatar.Logic.Monuments
{
    public abstract class Monument
    {
        public string Name { get; }

        protected Monument(string name) =>
            this.Name = name;

        public override string ToString()
        {
            var monumentTypeName = this.GetTypeName(nameof(Monument));

            return $"{monumentTypeName}: {this.Name}, {this.ToMonumentString()}";
        }

        public abstract uint CalculateNationPowerIncrease();

        protected abstract string ToMonumentString();
    }
}
