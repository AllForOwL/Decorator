using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var intDecorator = new IntDecorator(new IntComponent());
            intDecorator.OutputValue();

            var floatDecorator = new FloatDecorator(new FloatComponent());
            floatDecorator.OutputValue();

            var boolDecorator = new BoolDecorator(new BoolComponent());
            boolDecorator.OutputValue();

            Console.ReadKey();
        }
    }
}