using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Index                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 000 invalid                                  TextureId IL2CPP_TYPE_VALUETYPE
    public partial class TextureId : DataModel
    {
        public int                                      M_Index                                 { get; set; }

        public static TextureId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureId() { Pointer= p0 };

            value.M_Index                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A67A5090 0x10 M_Index                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
