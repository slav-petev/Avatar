namespace Avatar.Logic.Monuments
{
    public class WaterMonument : Monument
    {
        public uint WaterAffinity { get; }

        public WaterMonument(string name, uint waterAffinity)
            : base(name) => this.WaterAffinity = waterAffinity;

        public override uint CalculateNationPowerIncrease() =>
            this.WaterAffinity;

        protected override string ToMonumentString() =>
            $"Water Affinity: {this.WaterAffinity}";
    }
}
