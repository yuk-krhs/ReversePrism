using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 context                                  <uint> IL2CPP_TYPE_U
    // 018 Index                                    ModelPrimitiveType uint uint uint UInt32
    // 01C Frame                                    ModelPrimitiveType uint uint uint UInt32
    // 020 Type                                     ModelPrimitiveType uint uint uint UInt32
    // 000 nullRendererList                         RendererList IL2CPP_TYPE_VALUETYPE
    public partial class RendererList : DataModel
    {
        public uint                                     Index                                   { get; set; }
        public uint                                     Frame                                   { get; set; }
        public uint                                     Type                                    { get; set; }

        public static RendererList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererList() { Pointer= p0 };

            value.Index                                     = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Frame                                     = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Frame                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Type                                      = GetUInt32(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
