using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAngleRestoration                      ModelPrimitiveType bool bool bool Bool
    // 014 RestorationStiffness                     ModelEnumType float4x4 float4x4 float4x4 Int32
    // 054 RestorationVelocityAttenuation           ModelPrimitiveType float float float Single
    // 058 RestorationGravityFalloff                ModelPrimitiveType float float float Single
    // 05C UseAngleLimit                            ModelPrimitiveType bool bool bool Bool
    // 060 LimitCurveData                           ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0A0 Limitstiffness                           ModelPrimitiveType float float float Single
    public partial class AngleConstraintParams : DataModel
    {
        public bool                                     UseAngleRestoration                     { get; set; }
        public float4x4                                 RestorationStiffness                    { get; set; }
        public float                                    RestorationVelocityAttenuation          { get; set; }
        public float                                    RestorationGravityFalloff               { get; set; }
        public bool                                     UseAngleLimit                           { get; set; }
        public float4x4                                 LimitCurveData                          { get; set; }
        public float                                    Limitstiffness                          { get; set; }

        public static AngleConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AngleConstraintParams() { Pointer= p0 };

            value.UseAngleRestoration                       = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAngleRestoration         ( ModelPrimitiveType bool bool bool Bool )
            value.RestorationStiffness                      = (float4x4)GetInt32(new IntPtr(p + 0x014)); // 0x14 RestorationStiffness        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.RestorationVelocityAttenuation            = GetSingle(new IntPtr(p + 0x054)); // 0x54 RestorationVelocityAttenuation ( ModelPrimitiveType float float float Single )
            value.RestorationGravityFalloff                 = GetSingle(new IntPtr(p + 0x058)); // 0x58 RestorationGravityFalloff   ( ModelPrimitiveType float float float Single )
            value.UseAngleLimit                             = GetBool(new IntPtr(p + 0x05C)); // 0x5C UseAngleLimit               ( ModelPrimitiveType bool bool bool Bool )
            value.LimitCurveData                            = (float4x4)GetInt32(new IntPtr(p + 0x060)); // 0x60 LimitCurveData              ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.Limitstiffness                            = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 Limitstiffness              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
