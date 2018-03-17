using Avatar.Logic.Common.Extensions;

namespace Avatar.Logic.Benders
{
    public abstract class Bender
    {
        public string Name { get; }
        public uint Power { get; }

        protected Bender(string name, uint power)
        {
            this.Name = name;
            this.Power = power;
        }

        public override string ToString()
        {
            var benderTypeName = this.GetTypeName(nameof(Bender));

            return $"{benderTypeName}: {this.Name}, Power: {this.Power}, {this.ToBenderString()}";
        }

        public abstract double CalculateTotalPower();

        protected abstract string ToBenderString();
    }
}
