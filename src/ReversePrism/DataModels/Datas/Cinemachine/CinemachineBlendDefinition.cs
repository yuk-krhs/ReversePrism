using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Style                                  ModelEnumType Style Style Style Int32
    // 014 M_Time                                   ModelPrimitiveType float float float Single
    // 018 M_CustomCurve                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 000 sStandardCurves                          AnimationCurve[] IL2CPP_TYPE_SZARRAY
    public partial class CinemachineBlendDefinition : DataModel
    {
        public Style                                    M_Style                                 { get; set; }
        public float                                    M_Time                                  { get; set; }
        public AnimationCurve?                          M_CustomCurve                           { get; set; }

        public static CinemachineBlendDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBlendDefinition() { Pointer= p0 };

            value.M_Style                                   = (Style)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Style                     ( ModelEnumType Style Style Style Int32 )
            value.M_Time                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_Time                      ( ModelPrimitiveType float float float Single )
            value.M_CustomCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 M_CustomCurve               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
