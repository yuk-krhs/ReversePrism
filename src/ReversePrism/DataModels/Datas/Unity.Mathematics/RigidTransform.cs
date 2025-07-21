using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rot                                      ModelEnumType quaternion quaternion quaternion Int32
    // 020 Pos                                      ModelEnumType float3 float3 float3 Int32
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

            value.Rot                                       = (quaternion)GetInt32(new IntPtr(p + 0x010)); // 0x10 Rot                         ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.Pos                                       = (float3)GetInt32(new IntPtr(p + 0x020)); // 0x20 Pos                         ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
