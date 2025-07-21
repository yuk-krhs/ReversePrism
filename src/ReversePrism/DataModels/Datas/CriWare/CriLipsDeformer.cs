using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 UserModifyDelegate                       ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer
    // 038 LipsMorph                                ModelClassType ICriLipsMorph ICriLipsMorph ICriLipsMorph Pointer
    // 040 Info                                     ModelEnumType Info Info Info Int32
    // 050 BlendAmount                              ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32
    // 068 AnalyzeModule                            ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer
    // 070 SilicenInfo                              ModelEnumType Info Info Info Int32
    public partial class CriLipsDeformer : DataModel
    {
        public UserModifyDelegateFunction?              UserModifyDelegate                      { get; set; }
        public ICriLipsMorph?                           LipsMorph                               { get; set; }
        public Info                                     Info                                    { get; set; }
        public MorphTargetBlendAmountAsJapanese         BlendAmount                             { get; set; }
        public ICriLipsAnalyzeModule?                   AnalyzeModule                           { get; set; }
        public Info                                     SilicenInfo                             { get; set; }

        public static CriLipsDeformer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsDeformer() { Pointer= p0 };

            value.UserModifyDelegate                        = GetObject<UserModifyDelegateFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.UserModifyDelegateFunction.FromPointer); // 0x30 UserModifyDelegate          ( ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer )
            value.LipsMorph                                 = GetObject<ICriLipsMorph>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICriLipsMorph.FromPointer); // 0x38 LipsMorph                   ( ModelClassType ICriLipsMorph ICriLipsMorph ICriLipsMorph Pointer )
            value.Info                                      = (Info)GetInt32(new IntPtr(p + 0x040)); // 0x40 Info                        ( ModelEnumType Info Info Info Int32 )
            value.BlendAmount                               = (MorphTargetBlendAmountAsJapanese)GetInt32(new IntPtr(p + 0x050)); // 0x50 BlendAmount                 ( ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32 )
            value.AnalyzeModule                             = GetObject<ICriLipsAnalyzeModule>(new IntPtr(p + 0x068), ReversePrism.DataModels.ICriLipsAnalyzeModule.FromPointer); // 0x68 AnalyzeModule               ( ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer )
            value.SilicenInfo                               = (Info)GetInt32(new IntPtr(p + 0x070)); // 0x70 SilicenInfo                 ( ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
