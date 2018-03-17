using Avatar.Logic.Benders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avatar.Logic.Common.Extensions
{
    internal static class BenderExtensions
    {
        internal static string ToBendersStringRepresentation(
            this IEnumerable<Bender> benders)
        {
            var bendersTitle = "Benders:";
            if (!benders.Any()) return string.Concat(bendersTitle, " None");

            var bendersBuilder = new StringBuilder();
            bendersBuilder.AppendLine(bendersTitle);
            foreach (var bender in benders)
            {
                bendersBuilder.AppendFormat($"###{bender.ToString()}{Environment.NewLine}");
            }

            return bendersBuilder.ToString();
        }
    }
}
