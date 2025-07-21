using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Capacity                                 ModelPrimitiveType uint uint uint UInt32
    // 014 ActiveInstanceCount                      ModelPrimitiveType uint uint uint UInt32
    public partial class VFXBatchInfo : DataModel
    {
        public uint                                     Capacity                                { get; set; }
        public uint                                     ActiveInstanceCount                     { get; set; }

        public static VFXBatchInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXBatchInfo() { Pointer= p0 };

            value.Capacity                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Capacity                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.ActiveInstanceCount                       = GetUInt32(new IntPtr(p + 0x014)); // 0x14 ActiveInstanceCount         ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
