using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TextEditOp
    {
        MoveLeft,
        MoveRight,
        MoveUp,
        MoveDown,
        MoveLineStart,
        MoveLineEnd,
        MoveTextStart,
        MoveTextEnd,
        MovePageUp,
        MovePageDown,
        MoveGraphicalLineStart,
        MoveGraphicalLineEnd,
        MoveWordLeft,
        MoveWordRight,
        MoveParagraphForward,
        MoveParagraphBackward,
        MoveToStartOfNextWord,
        MoveToEndOfPreviousWord,
        Delete,
        Backspace,
        DeleteWordBack,
        DeleteWordForward,
        DeleteLineBack,
        Cut,
        Paste,
        ScrollStart,
        ScrollEnd,
        ScrollPageUp,
        ScrollPageDown,
    }
}
