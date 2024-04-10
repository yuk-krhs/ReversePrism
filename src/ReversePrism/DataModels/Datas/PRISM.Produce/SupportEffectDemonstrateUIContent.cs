using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportEffectContentList                 000185D10518 ModelClassListType List`1<SupportEffectContent> List`1<SupportEffectContent> List<SupportEffectContent> Pointer
    // 028 OnDisplayTapButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 038 IsTapped                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SupportEffectDemonstrateUIContent : DataModel
    {
        public List<SupportEffectContent>?              SupportEffectContentList                { get; set; }
        public UIButton?                                OnDisplayTapButton                      { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public bool                                     IsTapped                                { get; set; }

        public static SupportEffectDemonstrateUIContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectDemonstrateUIContent() { Pointer= p0 };

            value.SupportEffectContentList                  = GetObjectList<SupportEffectContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContent.FromPointer); // 024664C10E78 0x20 SupportEffectContentList    ( 000185D10518 ModelClassListType List`1<SupportEffectContent> List`1<SupportEffectContent> List<SupportEffectContent> Pointer )
            value.OnDisplayTapButton                        = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 024664C10E98 0x28 OnDisplayTapButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 024664C10EB8 0x30 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.IsTapped                                  = GetBool(new IntPtr(p + 0x038)); // 024664C10ED8 0x38 IsTapped                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
