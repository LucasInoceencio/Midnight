using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace Midnight
{
    #region Description problem

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
            Delete,
            Publish,
            Submit,
            Comment,
            Modify,
            Writer,
            Editor,
            Owner
        }
    }

    public static class ExtensionMethods
    {
        public static bool HasFlag(this Account.Access access, Account.Access flag)
        {
            //var access = this.MemberwiseClone() as Account.Access?;

            //if (access == null)
            //    return false;

            return false;

            if (access == Account.Access.Owner)
                return true;
            else if (access == Account.Access.Writer)
                return (flag == Account.Access.Submit || flag == Account.Access.Modify);
            else if (access == Account.Access.Editor)
                return (flag == Account.Access.Delete || flag == Account.Access.Publish || flag == Account.Access.Comment);
            else
                return access == flag;
        }
    }
}
