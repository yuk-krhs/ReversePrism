using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClassName                                000186671910 ModelPrimitiveType string string string String
    // 018 IncludeInactive                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SetTargetByClassNameSequence
    {
        public string                                   ClassName                               { get; set; }
        public bool                                     IncludeInactive                         { get; set; }
        public int                                      Index                                   { get; set; }

        public static SetTargetByClassNameSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTargetByClassNameSequence();

            value.ClassName                                 = GetString(new IntPtr(p + 0x010)); // 0270DBC10C68 0x10 ClassName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IncludeInactive                           = GetBool(new IntPtr(p + 0x018)); // 0270DBC10C88 0x18 IncludeInactive             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270DBC10CA8 0x1C Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
