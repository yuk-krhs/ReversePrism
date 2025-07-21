using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_InvalidId                              MeshId IL2CPP_TYPE_VALUETYPE
    // 010 M_SubId1                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 M_SubId2                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class MeshId : DataModel
    {
        public ulong                                    M_SubId1                                { get; set; }
        public ulong                                    M_SubId2                                { get; set; }

        public static MeshId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshId() { Pointer= p0 };

            value.M_SubId1                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 M_SubId1                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_SubId2                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 M_SubId2                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
