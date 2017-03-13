using Processor.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Processing
{
    public class ElementList : List<IElement>
    {
        private bool _isReverse;
        private int _currentIndex;

        public IElement LastElement
        {
            get
            {                                
                return this[this.Count - 1];
            }
        }
        
        public IElement NextElement
        {
            get
            {
                ReverseList();
                RemoveNullObjects();
                try
                {
                    return this[_currentIndex++];
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
                return _currentIndex == this.Count;
            }
        }        

        public void AddElement(IElement aElement)
        {
            if (_isReverse)
            {
                Clef aClef = (Clef)this[0];
                ReverseList();
                Insert(0, aClef);
            }
            else
            {
                if (aElement is Clef)
                {
                    if (this[0] is Clef)
                    {
                        RemoveAt(0);
                    }

                    Insert(0, aElement);
                }
                else
                {
                    Add(aElement);
                }
            }

            _currentIndex = 0;
        }  
        
        public List<IElement> GetElementList()
        {
            ReverseList();
            RemoveNullObjects();

            return this;
        }

        private void ReverseList()
        {
            if (!_isReverse)
            {
                Bar aBar = null;
                Clef aClef = (Clef) this[0];
                RemoveAt(0);

                if(this[this.Count-1] is Bar)
                {
                    aBar = (Bar)this[this.Count - 1];
                    RemoveAt(this.Count - 1);
                }

                _isReverse = true;
            }
        }

        private void RemoveNullObjects()
        {
            for (int i = 0; i < this.Count -1; i++)
            {
                if(this[i] == null)
                {
                    RemoveAt(i);
                }
            }
        }
    }          
}
