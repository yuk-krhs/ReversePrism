using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AttackShape                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 018 M_DecayShape                             ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 M_AttackTime                             ModelPrimitiveType float float float Single
    // 024 M_SustainTime                            ModelPrimitiveType float float float Single
    // 028 M_DecayTime                              ModelPrimitiveType float float float Single
    // 02C M_ScaleWithImpact                        ModelPrimitiveType bool bool bool Bool
    // 02D M_HoldForever                            ModelPrimitiveType bool bool bool Bool
    public partial class EnvelopeDefinition : DataModel
    {
        public AnimationCurve?                          M_AttackShape                           { get; set; }
        public AnimationCurve?                          M_DecayShape                            { get; set; }
        public float                                    M_AttackTime                            { get; set; }
        public float                                    M_SustainTime                           { get; set; }
        public float                                    M_DecayTime                             { get; set; }
        public bool                                     M_ScaleWithImpact                       { get; set; }
        public bool                                     M_HoldForever                           { get; set; }

        public static EnvelopeDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnvelopeDefinition() { Pointer= p0 };

            value.M_AttackShape                             = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x10 M_AttackShape               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_DecayShape                              = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 M_DecayShape                ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_AttackTime                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_AttackTime                ( ModelPrimitiveType float float float Single )
            value.M_SustainTime                             = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_SustainTime               ( ModelPrimitiveType float float float Single )
            value.M_DecayTime                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_DecayTime                 ( ModelPrimitiveType float float float Single )
            value.M_ScaleWithImpact                         = GetBool(new IntPtr(p + 0x02C)); // 0x2C M_ScaleWithImpact           ( ModelPrimitiveType bool bool bool Bool )
            value.M_HoldForever                             = GetBool(new IntPtr(p + 0x02D)); // 0x2D M_HoldForever               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
