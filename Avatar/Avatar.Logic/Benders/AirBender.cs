namespace Avatar.Logic.Benders
{
    public class AirBender : Bender
    {
        public double AerialIntegrity { get; }

        public AirBender(string name, uint power, double aerialIntegrity)
            : base(name, power) => this.AerialIntegrity = aerialIntegrity;

        public override double CalculateTotalPower() => 
            this.Power * this.AerialIntegrity;

        protected override string ToBenderString() =>
            $"Aerial Integrity: {this.AerialIntegrity}";
    }
}
