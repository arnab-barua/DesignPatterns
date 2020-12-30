namespace DesignPatterns.Behavioral.State
{
    // In State pattern this interface designated as the STATE
    // Implementation of this interface defines various state of CONTEXT (in this example Canvas)
    interface ITool
    {
        void MouseDown();
        void MouseUp();
    }
}
