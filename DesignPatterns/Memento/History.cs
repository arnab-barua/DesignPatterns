using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    // In Memento pattern this class is called the Caretaker.
    // This class is made Generic for reuse purpose.
    class History<TState> where TState: class 
    {
        private Stack<TState> states;
        

        public History()
        {
            states = new Stack<TState>();
        }

        public void Push(TState state)
        {
            states.Push(state);
        }

        public TState Pop()
        {
            return states.Pop();
        }
    }
}
