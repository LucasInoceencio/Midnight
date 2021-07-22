using Midnight;
using System;

namespace MidnightTest
{
    public class NumericInputFixture : IDisposable
    {
        public TextInput numericInput;
        
        public NumericInputFixture()
        {
            numericInput = new NumericInput();
        }

        public void NewInstance()
        {
            numericInput = new NumericInput();
        }

        public void Dispose() 
        {
            numericInput = null;
        }
    }
}
