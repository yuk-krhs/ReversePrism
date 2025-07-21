using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReleaseColor                             ModelEnumType Color Color Color Int32
    // 030 NonReleaseColor                          ModelEnumType Color Color Color Int32
    // 040 SkillEffectNameText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SkillEffectDescriptionText               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SkillEffectTargetCharaObjectList         ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 058 SkillEffectTargetCharaImageList          ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer
    // 060 SkillEffectTargetCharaCoverList          ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 068 BgImage                                  ModelClassType UIImage UIImage UIImage Pointer
    public partial class SupportEffectContent : DataModel
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
            var value   = new SupportEffectContent() { Pointer= p0 };

            value.ReleaseColor                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 ReleaseColor                ( ModelEnumType Color Color Color Int32 )
            value.NonReleaseColor                           = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 NonReleaseColor             ( ModelEnumType Color Color Color Int32 )
            value.SkillEffectNameText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 SkillEffectNameText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillEffectDescriptionText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 SkillEffectDescriptionText  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillEffectTargetCharaObjectList          = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SkillEffectTargetCharaObjectList ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.SkillEffectTargetCharaImageList           = GetObjectList<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 SkillEffectTargetCharaImageList ( ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer )
            value.SkillEffectTargetCharaCoverList           = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 SkillEffectTargetCharaCoverList ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 BgImage                     ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
