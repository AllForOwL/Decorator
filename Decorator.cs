using System;

namespace Decorator
{
    public interface IDecorator : IComponent
    {
       
    }

    public class IntDecorator : IDecorator
    {
        private readonly IComponent _component;

        public IntDecorator(IComponent component)
        {
            _component = component;
        }

        public void OutputValue()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            _component.OutputValue();
        }
    }

    public class FloatDecorator : IDecorator
    {
        private readonly IComponent _component;

        public FloatDecorator(IComponent component)
        {
            _component = component;
        }
        public void OutputValue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            _component.OutputValue();
        }
    }

    public class BoolDecorator : IDecorator
    {
        private readonly IComponent _component;

        public BoolDecorator(IComponent component)
        {
            _component = component;
        }
        public void OutputValue()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            _component.OutputValue();
        }
    }
}
