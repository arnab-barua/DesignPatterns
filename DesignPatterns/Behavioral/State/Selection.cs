using System;

namespace DesignPatterns.Behavioral.State
{
    class Selection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection : Started");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection : Rectangle is selectd");
        }
    }
}
