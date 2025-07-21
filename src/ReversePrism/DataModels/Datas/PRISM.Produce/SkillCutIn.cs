using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CutInType                                ModelEnumType CutInType CutInType CutInType Int32
    // 028 BgImage                                  ModelClassType Graphic Graphic Graphic Pointer
    // 030 CutInIdolImage                           ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 CutInAnimatorEvent                       ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 040 CutInModels                              ModelClassListType List`1<CutInModel> List`1<CutInModel> List<CutInModel> Pointer
    public partial class SkillCutIn : DataModel
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
            var value   = new SkillCutIn() { Pointer= p0 };

            value.CutInType                                 = (CutInType)GetInt32(new IntPtr(p + 0x020)); // 0x20 CutInType                   ( ModelEnumType CutInType CutInType CutInType Int32 )
            value.BgImage                                   = GetObject<Graphic>(new IntPtr(p + 0x028), ReversePrism.DataModels.Graphic.FromPointer); // 0x28 BgImage                     ( ModelClassType Graphic Graphic Graphic Pointer )
            value.CutInIdolImage                            = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 CutInIdolImage              ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CutInAnimatorEvent                        = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x38 CutInAnimatorEvent          ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.CutInModels                               = GetObjectList<CutInModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.CutInModel.FromPointer); // 0x40 CutInModels                 ( ModelClassListType List`1<CutInModel> List`1<CutInModel> List<CutInModel> Pointer )

            return value;
        }
    }
}
