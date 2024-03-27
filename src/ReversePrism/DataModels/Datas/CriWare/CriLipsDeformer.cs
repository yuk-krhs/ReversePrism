using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 UserModifyDelegate                       00018655D7F0 ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer
    // 038 LipsMorph                                000186746520 ModelClassType ICriLipsMorph ICriLipsMorph ICriLipsMorph Pointer
    // 040 Info                                     0001866EC0D0 ModelEnumType Info Info Info Int32
    // 050 BlendAmount                              0001866ECA70 ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32
    // 068 AnalyzeModule                            000186746040 ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer
    // 070 SilicenInfo                              0001866EBE00 ModelEnumType Info Info Info Int32
    public partial class CriLipsDeformer
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
            var value   = new CriLipsDeformer();

            value.UserModifyDelegate                        = GetObject<UserModifyDelegateFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.UserModifyDelegateFunction.FromPointer); // 0270DBBA63D8 0x30 UserModifyDelegate          ( 00018655D7F0 ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer )
            value.LipsMorph                                 = GetObject<ICriLipsMorph>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICriLipsMorph.FromPointer); // 0270DBBA63F8 0x38 LipsMorph                   ( 000186746520 ModelClassType ICriLipsMorph ICriLipsMorph ICriLipsMorph Pointer )
            value.Info                                      = (Info)GetInt32(new IntPtr(p + 0x040)); // 0270DBBA6418 0x40 Info                        ( 0001866EC0D0 ModelEnumType Info Info Info Int32 )
            value.BlendAmount                               = (MorphTargetBlendAmountAsJapanese)GetInt32(new IntPtr(p + 0x050)); // 0270DBBA6438 0x50 BlendAmount                 ( 0001866ECA70 ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32 )
            value.AnalyzeModule                             = GetObject<ICriLipsAnalyzeModule>(new IntPtr(p + 0x068), ReversePrism.DataModels.ICriLipsAnalyzeModule.FromPointer); // 0270DBBA6458 0x68 AnalyzeModule               ( 000186746040 ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer )
            value.SilicenInfo                               = (Info)GetInt32(new IntPtr(p + 0x070)); // 0270DBBA6478 0x70 SilicenInfo                 ( 0001866EBE00 ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
