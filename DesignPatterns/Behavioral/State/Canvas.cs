using System;

namespace DesignPatterns.Behavioral.State
{
    // In State pattern this class designated as the CONTEXT
    // This class behaves differently based on the supplied state.
    // In this example state is defined by various selected tools.
    class Canvas
    {
        private ITool _selectedTool;

        public Canvas()
        {
           
        }


        public void MouseUp()
        {
            if(_selectedTool == null)
                Console.WriteLine("Select a tool first");
            else 
                _selectedTool.MouseUp();
        }

        public void MouseDown()
        {
            if (_selectedTool == null)
                Console.WriteLine("Select a tool first");
            else
                _selectedTool.MouseDown();
        }

        public void SelectTool(ITool tool)
        {
            _selectedTool = tool;
        }
    }
}
