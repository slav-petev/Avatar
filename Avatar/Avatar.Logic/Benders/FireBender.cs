namespace Avatar.Logic.Benders
{
    public class FireBender : Bender
    {
        public double HeatAggression { get; }

        public FireBender(string name, uint power, double heatAggression)
            : base(name, power) => this.HeatAggression = heatAggression;

        public override double CalculateTotalPower() =>
            this.Power * this.HeatAggression;

        protected override string ToBenderString() =>
            $"Heat Aggression: {this.HeatAggression}";
    }
}
