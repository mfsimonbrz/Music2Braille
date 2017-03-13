namespace Processor.Base
{
    public class Clef : IElement
    {
        public Note Key { get; set; }
        public ClefInfo ClefInfo { get; set; }
        public EClefSymbol ClefSymbol { get; set; }

        public Clef(Note aKey, int aBeat, ENoteValue aNoteValue, EClefSymbol aClefSymbol)
        {
            Key = aKey;
            ClefInfo = new ClefInfo
            {
                Beat = aBeat,
                Value = aNoteValue
            };

            ClefSymbol = aClefSymbol;
        }
    }

    public class ClefInfo
    {
        public int Beat { get; set; }
        public ENoteValue Value { get; set; }
    }
}
