using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models.Enums
{
    public enum StageEnums
    {
        Any,
        Group_Stage,
        Round_Of_16,
        Quarter888finals,
        Semi888finals,
        Third888place_Match,
        Final
    }

    public static class StageEnumExtension
    {

        public static List<string> GetFriendlyNames(this Enum enm)
        {
            List<string> result = new List<string>();
            result.AddRange(Enum.GetNames(enm.GetType()).Select(s => s.ToFriendlyName()));
            return result;
        }

        public static string GetFriendlyName(this Enum enm)
        {
            return Enum.GetName(enm.GetType(), enm).ToFriendlyName();
        }

        private static string ToFriendlyName(this string orig)
        {
            return orig.Replace("_", " ").Replace("888", "-");
        }
    }
}
