using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models.Enums
{
    public enum StatsEnum
    {
        Goal,
        Save,
        Assist,
        Tackle,
        Red_card,
        Yellow_card
    }

    public static class StatsEnumExtension
    {

        public static List<string> GetNiceNames(this Enum enm)
        {
            List<string> result = new List<string>();
            result.AddRange(Enum.GetNames(enm.GetType()).Select(s => s.ToFriendlyName()));
            return result;
        }

        public static string GetNiceName(this Enum enm)
        {
            return Enum.GetName(enm.GetType(), enm).ToFriendlyName();
        }

        private static string ToFriendlyName(this string orig)
        {
            return orig.Replace("_", " ");
        }
    }
}
