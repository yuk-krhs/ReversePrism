using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DeviceId                               ModelPrimitiveType ulong ulong ulong UInt64
    // 018 M_FeatureIndex                           ModelPrimitiveType uint uint uint UInt32
    public partial class Bone : DataModel
    {
        public ulong                                    M_DeviceId                              { get; set; }
        public uint                                     M_FeatureIndex                          { get; set; }

        public static Bone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bone() { Pointer= p0 };

            value.M_DeviceId                                = GetUInt64(new IntPtr(p + 0x010)); // 0x10 M_DeviceId                  ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_FeatureIndex                            = GetUInt32(new IntPtr(p + 0x018)); // 0x18 M_FeatureIndex              ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
