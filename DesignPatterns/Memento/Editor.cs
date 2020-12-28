namespace DesignPatterns.Memento
{
    // In Memento pattern this class is called the Originator
    class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void RestoreState(EditorState state)
        {
            Content = state.Content;
        }
    }
}
