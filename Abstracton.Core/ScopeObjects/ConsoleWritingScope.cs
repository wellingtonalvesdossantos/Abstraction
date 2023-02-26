using System;

namespace Abstraction.Core.ScopeObjects
{
    public class ConsoleWritingScope : IDisposable
    {
        public ConsoleWritingScope()
        {
        }

        public void Dispose()
        {
            Console.ResetColor();
        }
    }
}
