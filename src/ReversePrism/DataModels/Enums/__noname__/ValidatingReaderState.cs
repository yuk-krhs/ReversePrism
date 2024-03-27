using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ValidatingReaderState
    {
        None,
        Init,
        Read,
        OnDefaultAttribute,
        OnReadAttributeValue,
        OnAttribute,
        ClearAttributes,
        ParseInlineSchema,
        ReadAhead,
        OnReadBinaryContent,
        ReaderClosed,
        EOF,
        Error,
    }
}
