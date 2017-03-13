using System;
using System.Collections.Generic;

namespace Processor.Processing
{
    public class BrailleNoteList : List<string>
    {
        private int _currentElement;

        public void AddElement(string aElement)
        {
            Add(aElement);
            _currentElement = 0;
        }

        public string NextElement
        {
            get
            {                
                try
                {
                    return this[_currentElement++];
                }
                catch (IndexOutOfRangeException ex)
                {
                    return null;
                }
            }
        }

        public bool IsEndOfList
        {
            get
            {
                return _currentElement == this.Count;
            }
        }
    }
}
