
namespace Midnight
{
    public class NumericInput : TextInput
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/user-input/47788?visibility=3&skillId=18

        // Level: Easy

        //User interface contains two types of user input controls: TextInput, which 
        //accepts all characters and NumericInput, which accepts only digits.

        //Implement the class TextInput that contains:
        //Public method void Add(char c) - adds the given character to the current value
        //Public method string GetValue() - returns the current value

        //Implement the class NumericInput that:
        //Inherits TextInput
        //Overrides the Add method so that each non-numeric character is ignored

        #endregion

        public override void Add(char c)
        {
            if (char.IsDigit(c))
                base.Add(c);
        }
    }
}
