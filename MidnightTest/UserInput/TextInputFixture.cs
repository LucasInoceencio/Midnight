using Midnight;
using System;

namespace MidnightTest
{
    public class TextInputFixture : IDisposable
    {
        public TextInput textInput;

        public TextInputFixture()
        {
            textInput = new TextInput();
        }

        public void NewInstance()
        {
            textInput = new TextInput();
        }

        public void Dispose() 
        {
            textInput = null;
        }
    }
}
