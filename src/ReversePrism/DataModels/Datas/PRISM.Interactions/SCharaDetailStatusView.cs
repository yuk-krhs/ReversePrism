using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 TxtAlias                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DiamondDisplay                           0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 040 SkillSlotIconView                        000186513E70 ModelClassType SkillSlotIconView SkillSlotIconView SkillSlotIconView Pointer
    // 048 SkillSlotParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ImgExpProgress                           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 TxtSpecialtySchedules                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GoCaution                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ImgFavoriteMark                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 078 BtnFavoriteMark                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 BtnFullImage                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
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

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A399910 0x20 SCharaIconRectView          ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A399930 0x28 TxtAlias                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A399950 0x30 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DiamondDisplay                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x038), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A399970 0x38 DiamondDisplay              ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.SkillSlotIconView                         = GetObject<SkillSlotIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkillSlotIconView.FromPointer); // 02466A399990 0x40 SkillSlotIconView           ( 000186513E70 ModelClassType SkillSlotIconView SkillSlotIconView SkillSlotIconView Pointer )
            value.SkillSlotParent                           = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466A3999B0 0x48 SkillSlotParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3999D0 0x50 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgExpProgress                            = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 02466A3999F0 0x58 ImgExpProgress              ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtSpecialtySchedules                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A399A10 0x60 TxtSpecialtySchedules       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoCaution                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466A399A30 0x68 GoCaution                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A399A50 0x70 ImgFavoriteMark             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavoriteMark                           = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466A399A70 0x78 BtnFavoriteMark             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnFullImage                              = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466A399A90 0x80 BtnFullImage                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
