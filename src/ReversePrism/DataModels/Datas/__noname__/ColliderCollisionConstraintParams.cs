using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     ModelEnumType Mode Mode Mode Int32
    // 014 DynamicFriction                          ModelPrimitiveType float float float Single
    // 018 StaticFriction                           ModelPrimitiveType float float float Single
    // 01C LimitDistance                            ModelEnumType float4x4 float4x4 float4x4 Int32
    public partial class ColliderCollisionConstraintParams : DataModel
    {
        public Mode                                     Mode                                    { get; set; }
        public float                                    DynamicFriction                         { get; set; }
        public float                                    StaticFriction                          { get; set; }
        public float4x4                                 LimitDistance                           { get; set; }

        public static ColliderCollisionConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderCollisionConstraintParams() { Pointer= p0 };

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x010)); // 0x10 Mode                        ( ModelEnumType Mode Mode Mode Int32 )
            value.DynamicFriction                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 DynamicFriction             ( ModelPrimitiveType float float float Single )
            value.StaticFriction                            = GetSingle(new IntPtr(p + 0x018)); // 0x18 StaticFriction              ( ModelPrimitiveType float float float Single )
            value.LimitDistance                             = (float4x4)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LimitDistance               ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
