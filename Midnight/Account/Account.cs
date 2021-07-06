using System;

namespace Midnight
{
    #region Description problem

    // Link: https://www.testdome.com/questions/c-sharp/account/32673?visibility=3&skillId=18

    // Level: Hard

    //Each account on a website has a set of access flags that represent a users access.

    //Update and extend the enum so that it contains three new access flags:

    //A Writer access flag that is made up of the Submit and Modify flags.
    //An Editor access flag that is made up of the Delete, Publish and Comment flags.
    //An Owner access that is made up of the Writer and Editor flags.

    #endregion

    public class Account
    {
        [Flags]
        public enum Access
        {
            Delete = 1,
            Publish = 2,
            Submit = 4,
            Comment = 8,
            Modify = 16,
            Writer = Submit | Modify,
            Editor = Delete | Publish | Comment,
            Owner = Writer | Editor
        }
    }
}
