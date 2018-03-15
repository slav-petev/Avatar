namespace Avatar.Logic.Monuments
{
    public class EarthMonument : Monument
    {
        public uint EarthAffinity { get; }

        public EarthMonument(string name, uint earthAffinity)
            : base(name) => this.EarthAffinity = earthAffinity;

        public override uint CalculateNationPowerIncrease() =>
            this.EarthAffinity;

        protected override string ToMonumentString() =>
            $"Earth Affinity: {this.EarthAffinity}";
    }
}
