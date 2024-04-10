using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    000186699A20 ModelPrimitiveType uint uint uint UInt32
    public partial class LoadCachedObjectInstruction : DataModel
    {
        public uint                                     Index                                   { get; set; }

        public static LoadCachedObjectInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadCachedObjectInstruction() { Pointer= p0 };

            value.Index                                     = GetUInt32(new IntPtr(p + 0x010)); // 02466A0A2BE0 0x10 Index                       ( 000186699A20 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
