using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum KeyboardNavigationOperation
    {
        None,
        SelectAll,
        Cancel,
        Submit,
        Previous,
        Next,
        MoveRight,
        MoveLeft,
        PageUp,
        PageDown,
        Begin,
        End,
    }
}
