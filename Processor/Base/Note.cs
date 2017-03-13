namespace Processor.Base
{
    public class Note : IElement
    {
        public ENote NoteName { get; set; }
        public int Eighth { get; set; }
        public ENoteValue NoteValue { get; set; }
        public EAccidental Accidental { get; set; }
        public EDotType DotType { get; set; }

        public Note(ENote aNote, int aOctave, ENoteValue aNoteValue,
            EAccidental aAccidental)
        {
            NoteName = aNote;
            Eighth = aOctave;
            NoteValue = aNoteValue;
            Accidental = aAccidental;            
        }

        public Note(ENote aNote, int aOctave, ENoteValue aNoteValue,
            EAccidental aAccidental, EDotType aDotType) : this(aNote, aOctave, aNoteValue, aAccidental)
        {            
            DotType = aDotType;
        }
    }
}
