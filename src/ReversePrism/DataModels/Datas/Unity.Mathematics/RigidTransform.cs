using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rot                                      0001865F4990 ModelEnumType quaternion quaternion quaternion Int32
    // 020 Pos                                      0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 000 identity                                 RigidTransform IL2CPP_TYPE_VALUETYPE
    public partial class RigidTransform : DataModel
    {
        public quaternion                               Rot                                     { get; set; }
        public float3                                   Pos                                     { get; set; }

        public static RigidTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RigidTransform() { Pointer= p0 };

            value.Rot                                       = (quaternion)GetInt32(new IntPtr(p + 0x010)); // 0245A15CD390 0x10 Rot                         ( 0001865F4990 ModelEnumType quaternion quaternion quaternion Int32 )
            value.Pos                                       = (float3)GetInt32(new IntPtr(p + 0x020)); // 0245A15CD3B0 0x20 Pos                         ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
