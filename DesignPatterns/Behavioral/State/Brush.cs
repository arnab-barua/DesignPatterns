using System;

namespace DesignPatterns.Behavioral.State
{
    class Brush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush : Started");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush : Painted a shape");
        }
    }
}
