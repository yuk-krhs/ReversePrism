using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_String                                 000186672F10 ModelPrimitiveType string string string String
    // 018 M_Index                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C M_Length                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Substring
    {
        public string                                   M_String                                { get; set; }
        public int                                      M_Index                                 { get; set; }
        public int                                      M_Length                                { get; set; }

        public static Substring? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Substring();

            value.M_String                                  = GetString(new IntPtr(p + 0x010)); // 0270D76D6730 0x10 M_String                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_Index                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D76D6750 0x18 M_Index                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_Length                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D76D6770 0x1C M_Length                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
