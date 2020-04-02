using System;

namespace HelloDI.LateBinding
{
    public class LateBoundConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"{message} - written by late bound message writer");
        }
    }
}