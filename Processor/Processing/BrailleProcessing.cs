using Processor.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Processing
{
    public class BrailleProcessing
    {
        private ElementList _elementList;
        private BrailleNoteList _brailleNoteList;
        private Dictionary<ENote, ENote[]> _scaleList;
        private Dictionary<ENote, ENote[]> _sharpList;
        private Dictionary<ENote, ENote[]> _flatList;
        private Note _lastNote;
        private Note _key;
        private int _barCount;

        public BrailleNoteList BrailleNoteList
        {
            get
            {
                return _brailleNoteList;
            }
        }

        public BrailleProcessing(ElementList aElementList)
        {
            _elementList = aElementList;
            _brailleNoteList = new BrailleNoteList();
            InitScaleList();
            InitSharpList();
            InitFlatList();
        }

        private void InitFlatList()
        {
            throw new NotImplementedException();
        }

        private void InitSharpList()
        {
            throw new NotImplementedException();
        }

        private void InitScaleList()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        private string ProcessTieElement(Tie aElement)
        {
            throw new NotImplementedException();
        }

        private string ProcessClefElement(Clef aElement)
        {
            throw new NotImplementedException();
        }

        private string ProcessRestElement(Rest aElement)
        {
            throw new NotImplementedException();
        }

        private string ProcessNoteElement(Note aElement)
        {
            throw new NotImplementedException();
        }

        private string ProcessAccidental(Note aElement)
        {
            throw new NotImplementedException();
        }

        private string GetOctave(Note aNote)
        {
            throw new NotImplementedException();
        }

        public String GetOctave(int aOctave)
        {
            throw new NotImplementedException();
        }

        private ENote GetRealNote(ENote aNote)
        {
            throw new NotImplementedException();
        }

        public int GetInterval(ENote aNote, ENote anotherNote)
        {
            throw new NotImplementedException();
        }

    }  

}
