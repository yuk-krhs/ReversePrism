using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 namePtr                                  <int> IL2CPP_TYPE_I
    // 018 Id                                       ModelPrimitiveType uint uint uint UInt32
    public partial class AisacControlInfoForMarshaling : DataModel
    {
        public uint                                     Id                                      { get; set; }

        public static AisacControlInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacControlInfoForMarshaling() { Pointer= p0 };

            value.Id                                        = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
