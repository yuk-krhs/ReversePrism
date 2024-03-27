using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TextSelectOp
    {
        SelectLeft,
        SelectRight,
        SelectUp,
        SelectDown,
        SelectTextStart,
        SelectTextEnd,
        SelectPageUp,
        SelectPageDown,
        ExpandSelectGraphicalLineStart,
        ExpandSelectGraphicalLineEnd,
        SelectGraphicalLineStart,
        SelectGraphicalLineEnd,
        SelectWordLeft,
        SelectWordRight,
        SelectToEndOfPreviousWord,
        SelectToStartOfNextWord,
        SelectParagraphBackward,
        SelectParagraphForward,
        Copy,
        SelectAll,
        SelectNone,
    }
}
