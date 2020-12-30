using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.State;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestMemento();
            TestState();
            
        }


        public static void TestState()
        {
            ITool tool = new Selection();
            var canvas = new Canvas();

            canvas.MouseDown();
            canvas.MouseUp();

            tool = new Brush();
            canvas.SelectTool(tool);

            canvas.MouseDown();
            canvas.MouseUp();
        }

        public static void TestMemento()
        {
            var editor = new Editor();
            var history = new History<EditorState>();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";

            Console.WriteLine(editor.Content);

            editor.RestoreState(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
