using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultRecursionLimit                    int IL2CPP_TYPE_I4
    // 000 DefaultSizeLimit                         int IL2CPP_TYPE_I4
    // 010 buffer                                   ReadOnlySpan`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 020 State                                    00018663CBD0 ModelEnumType ParserInternalState ParserInternalState ParserInternalState Int32
    public partial class ParseContext
    {
        public ParserInternalState                      State                                   { get; set; }

        public static ParseContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParseContext();

            value.State                                     = (ParserInternalState)GetInt32(new IntPtr(p + 0x020)); // 0270D3948E40 0x20 State                       ( 00018663CBD0 ModelEnumType ParserInternalState ParserInternalState ParserInternalState Int32 )

            return value;
        }
    }
}
