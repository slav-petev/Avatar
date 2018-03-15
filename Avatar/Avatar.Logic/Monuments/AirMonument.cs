namespace Avatar.Logic.Monuments
{
    public class AirMonument : Monument
    {
        public uint AirAffinity { get; }

        public AirMonument(string name, uint airAffinity)
            : base(name) => this.AirAffinity = airAffinity;

        public override uint CalculateNationPowerIncrease() =>
            this.AirAffinity;

        protected override string ToMonumentString() =>
            $"Air Affinity: {this.AirAffinity}";
    }
}
