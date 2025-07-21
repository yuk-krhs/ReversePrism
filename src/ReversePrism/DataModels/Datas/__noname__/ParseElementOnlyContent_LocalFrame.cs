using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartParenEntityId                       ModelPrimitiveType int int int Int32
    // 014 ParsingSchema                            ModelEnumType Token Token Token Int32
    public partial class ParseElementOnlyContent_LocalFrame : DataModel
    {
        public int                                      StartParenEntityId                      { get; set; }
        public Token                                    ParsingSchema                           { get; set; }

        public static ParseElementOnlyContent_LocalFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParseElementOnlyContent_LocalFrame() { Pointer= p0 };

            value.StartParenEntityId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartParenEntityId          ( ModelPrimitiveType int int int Int32 )
            value.ParsingSchema                             = (Token)GetInt32(new IntPtr(p + 0x014)); // 0x14 ParsingSchema               ( ModelEnumType Token Token Token Int32 )

            return value;
        }
    }
}
