using System;

namespace Decorator
{
    public interface IComponent
    {
        void OutputValue();
    }

    public class IntComponent : IComponent
    {
        public void OutputValue()
        {
            Console.WriteLine("It is Int");
        }
    }

    public class FloatComponent : IComponent
    {
        public void OutputValue()
        {
            Console.WriteLine("It is Float");
        }
    }

    public class BoolComponent : IComponent
    {
        public void OutputValue()
        {
            Console.WriteLine("It is Bool");
        }
    }
}
