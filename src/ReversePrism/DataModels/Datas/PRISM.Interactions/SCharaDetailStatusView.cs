using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 TxtAlias                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DiamondDisplay                           ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 040 SkillSlotIconView                        ModelClassType SkillSlotIconView SkillSlotIconView SkillSlotIconView Pointer
    // 048 SkillSlotParent                          ModelClassType Transform Transform Transform Pointer
    // 050 TxtLv                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ImgExpProgress                           ModelClassType Image Image Image Pointer
    // 060 TxtSpecialtySchedules                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GoCaution                                ModelClassType GameObject GameObject GameObject Pointer
    // 070 ImgFavoriteMark                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 078 BtnFavoriteMark                          ModelClassType UIButton UIButton UIButton Pointer
    // 080 BtnFullImage                             ModelClassType UIButton UIButton UIButton Pointer
    // 088 onFavoriteMark                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onFullImage                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SCharaDetailStatusView : DataModel
    {
        public SCharaIconRectView?                      SCharaIconRectView                      { get; set; }
        public UITextMeshProUGUI?                       TxtAlias                                { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public DiamondDisplay?                          DiamondDisplay                          { get; set; }
        public SkillSlotIconView?                       SkillSlotIconView                       { get; set; }
        public Transform?                               SkillSlotParent                         { get; set; }
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public Image?                                   ImgExpProgress                          { get; set; }
        public UITextMeshProUGUI?                       TxtSpecialtySchedules                   { get; set; }
        public GameObject?                              GoCaution                               { get; set; }
        public UIRawImage?                              ImgFavoriteMark                         { get; set; }
        public UIButton?                                BtnFavoriteMark                         { get; set; }
        public UIButton?                                BtnFullImage                            { get; set; }

        public static SCharaDetailStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailStatusView() { Pointer= p0 };

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x20 SCharaIconRectView          ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtAlias                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x038), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x38 DiamondDisplay              ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.SkillSlotIconView                         = GetObject<SkillSlotIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkillSlotIconView.FromPointer); // 0x40 SkillSlotIconView           ( ModelClassType SkillSlotIconView SkillSlotIconView SkillSlotIconView Pointer )
            value.SkillSlotParent                           = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 SkillSlotParent             ( ModelClassType Transform Transform Transform Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtLv                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgExpProgress                            = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 ImgExpProgress              ( ModelClassType Image Image Image Pointer )
            value.TxtSpecialtySchedules                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtSpecialtySchedules       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoCaution                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GoCaution                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x70 ImgFavoriteMark             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavoriteMark                           = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 BtnFavoriteMark             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnFullImage                              = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 BtnFullImage                ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
