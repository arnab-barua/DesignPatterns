using DesignPatterns.Memento;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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
