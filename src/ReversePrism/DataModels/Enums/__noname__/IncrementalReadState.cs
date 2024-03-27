using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum IncrementalReadState
    {
        Text,
        StartTag,
        PI,
        CDATA,
        Comment,
        Attributes,
        AttributeValue,
        ReadData,
        EndElement,
        End,
        ReadValueChunk_OnCachedValue,
        ReadValueChunk_OnPartialValue,
        ReadContentAsBinary_OnCachedValue,
        ReadContentAsBinary_OnPartialValue,
        ReadContentAsBinary_End,
    }
}
