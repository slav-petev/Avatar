using Avatar.Logic.Benders;
using Avatar.Logic.Common.Extensions;
using Avatar.Logic.Monuments;
using System;
using System.Collections.Generic;

namespace Avatar.Logic.Nations
{
    public abstract class Nation
    {
        private readonly List<Bender> _benders =
            new List<Bender>();
        private readonly List<Monument> _monuments =
            new List<Monument>();

        public void AddBender(Bender bender) =>
            _benders.Add(bender);
        public void AddMonument(Monument monument) =>
            _monuments.Add(monument);

        public void LoseWar()
        {
            _benders.Clear();
            _monuments.Clear();
        }

        public override string ToString()
        {
            var nationTypeName = this.GetTypeName(nameof(Nation));
            return $"{nationTypeName} Nation{Environment.NewLine}{_benders.ToBendersStringRepresentation()}{_monuments.ToMonumentsStringRepresentation()}";
        }
    }
}
