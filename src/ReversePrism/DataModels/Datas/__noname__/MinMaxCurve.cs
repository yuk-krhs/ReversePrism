using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Mode                                   000186724AD0 ModelEnumType ParticleSystemCurveMode ParticleSystemCurveMode ParticleSystemCurveMode Int32
    // 014 M_CurveMultiplier                        0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_CurveMin                               000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 M_CurveMax                               000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 M_ConstantMin                            0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_ConstantMax                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class MinMaxCurve
    {
        public ParticleSystemCurveMode                  M_Mode                                  { get; set; }
        public float                                    M_CurveMultiplier                       { get; set; }
        public AnimationCurve?                          M_CurveMin                              { get; set; }
        public AnimationCurve?                          M_CurveMax                              { get; set; }
        public float                                    M_ConstantMin                           { get; set; }
        public float                                    M_ConstantMax                           { get; set; }

        public static MinMaxCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinMaxCurve();

            value.M_Mode                                    = (ParticleSystemCurveMode)GetInt32(new IntPtr(p + 0x010)); // 02700696D208 0x10 M_Mode                      ( 000186724AD0 ModelEnumType ParticleSystemCurveMode ParticleSystemCurveMode ParticleSystemCurveMode Int32 )
            value.M_CurveMultiplier                         = GetSingle(new IntPtr(p + 0x014)); // 02700696D228 0x14 M_CurveMultiplier           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CurveMin                                = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 02700696D248 0x18 M_CurveMin                  ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_CurveMax                                = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 02700696D268 0x20 M_CurveMax                  ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_ConstantMin                             = GetSingle(new IntPtr(p + 0x028)); // 02700696D288 0x28 M_ConstantMin               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ConstantMax                             = GetSingle(new IntPtr(p + 0x02C)); // 02700696D2A8 0x2C M_ConstantMax               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
