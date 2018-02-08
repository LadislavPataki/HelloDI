using System;

namespace HelloDI.LateBinding
{
    public class LateBindedConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"{message} - late binding message writer");
        }
    }
}