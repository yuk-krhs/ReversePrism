using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Version                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class AllocatorHandle : DataModel
    {
        public ushort                                   Index                                   { get; set; }
        public ushort                                   Version                                 { get; set; }

        public static AllocatorHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocatorHandle() { Pointer= p0 };

            value.Index                                     = GetUInt16(new IntPtr(p + 0x010)); // 0245A3499118 0x10 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Version                                   = GetUInt16(new IntPtr(p + 0x012)); // 0245A3499138 0x12 Version                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
