using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReleaseColor                             0001865AA8E0 ModelEnumType Color Color Color Int32
    // 030 NonReleaseColor                          0001865AA8E0 ModelEnumType Color Color Color Int32
    // 040 SkillEffectNameText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SkillEffectDescriptionText               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SkillEffectTargetCharaObjectList         000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 058 SkillEffectTargetCharaImageList          000185D17EF8 ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer
    // 060 SkillEffectTargetCharaCoverList          000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 068 BgImage                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class SupportEffectContent
    {
        public Color                                    ReleaseColor                            { get; set; }
        public Color                                    NonReleaseColor                         { get; set; }
        public UITextMeshProUGUI?                       SkillEffectNameText                     { get; set; }
        public UITextMeshProUGUI?                       SkillEffectDescriptionText              { get; set; }
        public List<GameObject>?                        SkillEffectTargetCharaObjectList        { get; set; }
        public List<UIImage>?                           SkillEffectTargetCharaImageList         { get; set; }
        public List<GameObject>?                        SkillEffectTargetCharaCoverList         { get; set; }
        public UIImage?                                 BgImage                                 { get; set; }

        public static SupportEffectContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContent();

            value.ReleaseColor                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270D5C83270 0x20 ReleaseColor                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.NonReleaseColor                           = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270D5C83290 0x30 NonReleaseColor             ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SkillEffectNameText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C832B0 0x40 SkillEffectNameText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillEffectDescriptionText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C832D0 0x48 SkillEffectDescriptionText  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillEffectTargetCharaObjectList          = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C832F0 0x50 SkillEffectTargetCharaObjectList ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.SkillEffectTargetCharaImageList           = GetObjectList<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5C83310 0x58 SkillEffectTargetCharaImageList ( 000185D17EF8 ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer )
            value.SkillEffectTargetCharaCoverList           = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C83330 0x60 SkillEffectTargetCharaCoverList ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5C83350 0x68 BgImage                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
