using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Base
{
    public enum ERestValue : int
    {
        WholeRest = 1, HalfRest = 2, QuarterRest = 4, EightRest = 8, SixteenthRest = 16,
        ThirtySecondRest = 32, SixtyFourthRest = 64
    }

    public enum ENoteValue : int
    {
        WholeNote = 1, HalfNote = 2, QuarterNote = 4, EightNote = 8, SixteenthNote = 16,
        ThirtySecondNote = 32, SixtyFourthNote = 64
    }

    public enum ENote
    {
        C, CSharp, D, DSharp, E, FFlat, F, FSharp, G, GSharp, A, ASharp, B
    }

    public enum EClefSymbol
    {
        TrebleClef, BassClef
    }

    public enum EAccidental
    {
        Natural, Sharp, DoubleSharp, Flat, DoubleFlat
    }

    public enum EDotType
    {
        SingleDot, DoubleDot
    }
}
