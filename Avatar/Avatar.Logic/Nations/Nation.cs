using Avatar.Logic.Benders;
using Avatar.Logic.Common.Extensions;
using Avatar.Logic.Monuments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avatar.Logic.Nations
{
    public abstract class Nation
    {
        private const double ZERO_POWER = default(double);
        private const uint NO_MONUMENT_BONUS = default(uint);

        private readonly List<Bender> _benders =
            new List<Bender>();
        private readonly List<Monument> _monuments =
            new List<Monument>();

        public void AddBender(Bender bender) =>
            _benders.Add(bender);
        public void AddMonument(Monument monument) =>
            _monuments.Add(monument);

        public double CalculateTotalPower()
        {
            var basePower = this.CalculateBasePower();
            var bonusPercentage = this.CalculateMonumentBonusPercentage();
            var totalPower = (basePower / 100) * bonusPercentage;

            return totalPower;
        }

        private double CalculateBasePower()
        {
            return !_benders.Any()
                ? ZERO_POWER
                : _benders.Sum(bender => bender.CalculateTotalPower());
        }

        private long CalculateMonumentBonusPercentage()
        {
            return !_monuments.Any()
                ? NO_MONUMENT_BONUS
                : _monuments.Sum(monument => monument.CalculateNationPowerIncrease());
        }

        public void LoseWar()
        {
            _benders.Clear();
            _monuments.Clear();
        }

        public override string ToString()
        {
            var nationTypeName = this.GetTypeName(nameof(Nation));
            return $"{nationTypeName}{Environment.NewLine}{_benders.ToBendersStringRepresentation()}{_monuments.ToMonumentsStringRepresentation()}";
        }
    }
}
