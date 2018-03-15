namespace Avatar.Logic.Monuments
{
    public class FireMonument : Monument
    {
        public uint FireAffinity { get; }

        public FireMonument(string name, uint fireAffinity)
            : base(name) => this.FireAffinity = fireAffinity;

        public override uint CalculateNationPowerIncrease() =>
            this.FireAffinity;

        protected override string ToMonumentString() =>
            $"Fire Affinity: {this.FireAffinity}";
    }
}
