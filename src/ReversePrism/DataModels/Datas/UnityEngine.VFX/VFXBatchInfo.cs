using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Capacity                                 0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 ActiveInstanceCount                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class VFXBatchInfo
    {
        public uint                                     Capacity                                { get; set; }
        public uint                                     ActiveInstanceCount                     { get; set; }

        public static VFXBatchInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXBatchInfo();

            value.Capacity                                  = GetUInt32(new IntPtr(p + 0x010)); // 027002195480 0x10 Capacity                    ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ActiveInstanceCount                       = GetUInt32(new IntPtr(p + 0x014)); // 0270021954A0 0x14 ActiveInstanceCount         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
