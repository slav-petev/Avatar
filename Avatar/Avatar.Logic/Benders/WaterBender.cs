namespace Avatar.Logic.Benders
{
    public class WaterBender : Bender
    {
        public double WaterClarity { get; }

        public WaterBender(string name, uint power, double waterClarity)
            : base(name, power) => this.WaterClarity = waterClarity;

        public override double CalculateTotalPower() =>
            this.Power * this.WaterClarity;

        protected override string ToBenderString() =>
            $"Water Clarity: {this.WaterClarity}";
    }
}
