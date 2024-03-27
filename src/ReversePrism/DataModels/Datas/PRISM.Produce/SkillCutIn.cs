using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CutInType                                00018653A710 ModelEnumType CutInType CutInType CutInType Int32
    // 028 BgImage                                  0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 030 CutInIdolImage                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 CutInAnimatorEvent                       0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 040 CutInModels                              000185D2BA88 ModelClassListType List`1<CutInModel> List`1<CutInModel> List<CutInModel> Pointer
    public partial class SkillCutIn
    {
        public CutInType                                CutInType                               { get; set; }
        public Graphic?                                 BgImage                                 { get; set; }
        public UIRawImage?                              CutInIdolImage                          { get; set; }
        public AnimatorWithEvent?                       CutInAnimatorEvent                      { get; set; }
        public List<CutInModel>?                        CutInModels                             { get; set; }

        public static SkillCutIn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillCutIn();

            value.CutInType                                 = (CutInType)GetInt32(new IntPtr(p + 0x020)); // 0270D5BCD6E8 0x20 CutInType                   ( 00018653A710 ModelEnumType CutInType CutInType CutInType Int32 )
            value.BgImage                                   = GetObject<Graphic>(new IntPtr(p + 0x028), ReversePrism.DataModels.Graphic.FromPointer); // 0270D5BCD708 0x28 BgImage                     ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.CutInIdolImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5BCD728 0x30 CutInIdolImage              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CutInAnimatorEvent                        = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270D5BCD748 0x38 CutInAnimatorEvent          ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.CutInModels                               = GetObjectList<CutInModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.CutInModel.FromPointer); // 0270D5BCD768 0x40 CutInModels                 ( 000185D2BA88 ModelClassListType List`1<CutInModel> List`1<CutInModel> List<CutInModel> Pointer )

            return value;
        }
    }
}
