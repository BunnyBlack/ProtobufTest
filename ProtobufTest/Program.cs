using System;
using Foo.bar;

namespace ProtobufTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var message = new SimpleMessage();
            message.Name = "name";
            Console.WriteLine(string.IsNullOrEmpty(message.Name));
            Console.WriteLine(message.TestOneofCase);
            message.SubMessage = new SubMessage();
            Console.WriteLine(string.IsNullOrEmpty(message.Name));
            Console.WriteLine(message.TestOneofCase);
        }
    }
}
