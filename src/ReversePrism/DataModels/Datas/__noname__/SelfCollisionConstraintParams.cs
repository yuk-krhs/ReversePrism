using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelfMode                                 ModelEnumType SelfCollisionMode SelfCollisionMode SelfCollisionMode Int32
    // 014 SurfaceThicknessCurveData                ModelEnumType float4x4 float4x4 float4x4 Int32
    // 054 SyncMode                                 ModelEnumType SelfCollisionMode SelfCollisionMode SelfCollisionMode Int32
    // 058 ClothMass                                ModelPrimitiveType float float float Single
    public partial class SelfCollisionConstraintParams : DataModel
    {
        public SelfCollisionMode                        SelfMode                                { get; set; }
        public float4x4                                 SurfaceThicknessCurveData               { get; set; }
        public SelfCollisionMode                        SyncMode                                { get; set; }
        public float                                    ClothMass                               { get; set; }

        public static SelfCollisionConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelfCollisionConstraintParams() { Pointer= p0 };

            value.SelfMode                                  = (SelfCollisionMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 SelfMode                    ( ModelEnumType SelfCollisionMode SelfCollisionMode SelfCollisionMode Int32 )
            value.SurfaceThicknessCurveData                 = (float4x4)GetInt32(new IntPtr(p + 0x014)); // 0x14 SurfaceThicknessCurveData   ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.SyncMode                                  = (SelfCollisionMode)GetInt32(new IntPtr(p + 0x054)); // 0x54 SyncMode                    ( ModelEnumType SelfCollisionMode SelfCollisionMode SelfCollisionMode Int32 )
            value.ClothMass                                 = GetSingle(new IntPtr(p + 0x058)); // 0x58 ClothMass                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
