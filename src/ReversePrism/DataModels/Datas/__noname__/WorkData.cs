using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Aabb                                     ModelEnumType AABB AABB AABB Int32
    // 028 Radius                                   ModelEnumType float2 float2 float2 Int32
    // 030 OldPos                                   ModelEnumType float3x2 float3x2 float3x2 Int32
    // 048 NextPos                                  ModelEnumType float3x2 float3x2 float3x2 Int32
    // 060 InverseOldRot                            ModelEnumType quaternion quaternion quaternion Int32
    // 070 Rot                                      ModelEnumType quaternion quaternion quaternion Int32
    public partial class WorkData : DataModel
    {
        public AABB                                     Aabb                                    { get; set; }
        public float2                                   Radius                                  { get; set; }
        public float3x2                                 OldPos                                  { get; set; }
        public float3x2                                 NextPos                                 { get; set; }
        public quaternion                               InverseOldRot                           { get; set; }
        public quaternion                               Rot                                     { get; set; }

        public static WorkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WorkData() { Pointer= p0 };

            value.Aabb                                      = (AABB)GetInt32(new IntPtr(p + 0x010)); // 0x10 Aabb                        ( ModelEnumType AABB AABB AABB Int32 )
            value.Radius                                    = (float2)GetInt32(new IntPtr(p + 0x028)); // 0x28 Radius                      ( ModelEnumType float2 float2 float2 Int32 )
            value.OldPos                                    = (float3x2)GetInt32(new IntPtr(p + 0x030)); // 0x30 OldPos                      ( ModelEnumType float3x2 float3x2 float3x2 Int32 )
            value.NextPos                                   = (float3x2)GetInt32(new IntPtr(p + 0x048)); // 0x48 NextPos                     ( ModelEnumType float3x2 float3x2 float3x2 Int32 )
            value.InverseOldRot                             = (quaternion)GetInt32(new IntPtr(p + 0x060)); // 0x60 InverseOldRot               ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.Rot                                       = (quaternion)GetInt32(new IntPtr(p + 0x070)); // 0x70 Rot                         ( ModelEnumType quaternion quaternion quaternion Int32 )

            return value;
        }
    }
}
