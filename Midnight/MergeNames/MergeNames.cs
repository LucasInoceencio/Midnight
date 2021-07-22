using System.Linq;

namespace Midnight
{
    public static class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var distinctNames = names1.ToList();
            distinctNames.AddRange(names2);
            return distinctNames.Distinct().ToArray();
        }
    }
}
