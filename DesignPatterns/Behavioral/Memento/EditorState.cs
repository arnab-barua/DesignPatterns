namespace DesignPatterns.Behavioral.Memento
{
    // In Memento pattern this class is called the Memento
    class EditorState
    {
        public readonly string Content;

        public EditorState(string content)
        {
            Content = content;
        }
    }
}
