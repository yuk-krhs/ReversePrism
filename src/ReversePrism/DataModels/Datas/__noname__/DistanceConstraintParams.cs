using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RestorationStiffness                     ModelEnumType float4x4 float4x4 float4x4 Int32
    // 050 VelocityAttenuation                      ModelPrimitiveType float float float Single
    public partial class DistanceConstraintParams : DataModel
    {
        public float4x4                                 RestorationStiffness                    { get; set; }
        public float                                    VelocityAttenuation                     { get; set; }

        public static DistanceConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DistanceConstraintParams() { Pointer= p0 };

            value.RestorationStiffness                      = (float4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 RestorationStiffness        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.VelocityAttenuation                       = GetSingle(new IntPtr(p + 0x050)); // 0x50 VelocityAttenuation         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
