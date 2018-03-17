using Avatar.Logic.Monuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avatar.Logic.Common.Extensions
{
    internal static class MonumentExtensions
    {
        internal static string ToMonumentsStringRepresentation(
            this IEnumerable<Monument> monuments)
        {
            var monumentsTitle = "Monuments:";
            if (!monuments.Any()) return string.Concat(monumentsTitle, " None");

            var monumentsBuilder = new StringBuilder();
            monumentsBuilder.AppendLine(monumentsTitle);
            foreach (var monument in monuments)
            {
                monumentsBuilder.AppendFormat($"###{monument.ToString()}{Environment.NewLine}");
            }

            return monumentsBuilder.ToString();
        }
    }
}
