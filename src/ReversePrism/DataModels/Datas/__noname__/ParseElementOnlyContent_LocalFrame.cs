using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartParenEntityId                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ParsingSchema                            0001865C5080 ModelEnumType Token Token Token Int32
    public partial class ParseElementOnlyContent_LocalFrame
    {
        public int                                      StartParenEntityId                      { get; set; }
        public Token                                    ParsingSchema                           { get; set; }

        public static ParseElementOnlyContent_LocalFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParseElementOnlyContent_LocalFrame();

            value.StartParenEntityId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D7476C38 0x10 StartParenEntityId          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ParsingSchema                             = (Token)GetInt32(new IntPtr(p + 0x014)); // 0270D7476C58 0x14 ParsingSchema               ( 0001865C5080 ModelEnumType Token Token Token Int32 )

            return value;
        }
    }
}
