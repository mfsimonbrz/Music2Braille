using System.Collections.Generic;

namespace Processor.Base
{
    public class Tie : List<Note>, IElement
    {        
        private int _currentIndex;
        
        public bool LastTiedNote
        {
            get
            {
                return Count == _currentIndex;
            }
        }

        public Note NextNote
        {
            get
            {
                return this[_currentIndex++];
            }
        }        

        public void AddNote(Note aNote)
        {
            if(aNote != null)
            {
                Add(aNote);                
            }
        }
    }
}
