using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAngleRestoration                      ModelPrimitiveType bool bool bool Bool
    // 018 Stiffness                                ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer
    // 020 VelocityAttenuation                      ModelPrimitiveType float float float Single
    // 024 GravityFalloff                           ModelPrimitiveType float float float Single
    public partial class RestorationSerializeData : DataModel
    {
        public bool                                     UseAngleRestoration                     { get; set; }
        public CurveSerializeData?                      Stiffness                               { get; set; }
        public float                                    VelocityAttenuation                     { get; set; }
        public float                                    GravityFalloff                          { get; set; }

        public static RestorationSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RestorationSerializeData() { Pointer= p0 };

            value.UseAngleRestoration                       = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAngleRestoration         ( ModelPrimitiveType bool bool bool Bool )
            value.Stiffness                                 = GetObject<CurveSerializeData>(new IntPtr(p + 0x018), ReversePrism.DataModels.CurveSerializeData.FromPointer); // 0x18 Stiffness                   ( ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer )
            value.VelocityAttenuation                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 VelocityAttenuation         ( ModelPrimitiveType float float float Single )
            value.GravityFalloff                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 GravityFalloff              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
