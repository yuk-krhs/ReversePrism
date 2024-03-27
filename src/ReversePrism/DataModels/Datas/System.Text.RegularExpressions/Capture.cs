using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Text                                     000186671910 ModelPrimitiveType string string string String
    public partial class Capture
    {
        public int                                      Index                                   { get; set; }
        public int                                      Length                                  { get; set; }
        public string                                   Text                                    { get; set; }

        public static Capture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Capture();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270001ECD48 0x10 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0270001ECD68 0x14 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270001ECD88 0x18 Text                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
