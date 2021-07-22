using System.Linq;

namespace Midnight
{
    public static class MergeNames
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/merge-names/47835?visibility=3&skillId=18

        // Level: Easy

        //Implement the UniqueNames method.When passed two arrays of names, it will return an array
        //containing the names that appear in either or both arrays. The returned array should have no duplicates.

        //For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'},
        //new string[]{'Olivia', 'Sophia', 'Emma'}) should return an array
        //containing Ava, Emma, Olivia, and Sophia in any order.

        #endregion

        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var distinctNames = names1.ToList();
            distinctNames.AddRange(names2);
            return distinctNames.Distinct().ToArray();
        }
    }
}
