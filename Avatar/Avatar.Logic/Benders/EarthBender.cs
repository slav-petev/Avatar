namespace Avatar.Logic.Benders
{
    public class EarthBender : Bender
    {
        public double EarthSaturation { get; }

        public EarthBender(string name, uint power, double earthSaturation)
            : base(name, power) => this.EarthSaturation = earthSaturation;

        public override double CalculateTotalPower() =>
            this.Power * this.EarthSaturation;

        protected override string ToBenderString() =>
            $"Earth Saturation: {this.EarthSaturation}";
    }
}
