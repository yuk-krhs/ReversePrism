using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 Icon                                     000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ImgItemBase                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 ImgItemFrame                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CostumeDetailPopupCaller                 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer
    // 050 AchievemntDetailCaller                   000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    public partial class RewardItem : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public RawImage?                                Icon                                    { get; set; }
        public RawImage?                                ImgItemBase                             { get; set; }
        public RawImage?                                ImgItemFrame                            { get; set; }
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public CostumeDetailPopupCaller?                CostumeDetailPopupCaller                { get; set; }
        public AchievementDetailPopupCaller?            AchievemntDetailCaller                  { get; set; }

        public static RewardItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardItem() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 024664C21BC0 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Icon                                      = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 024664C21BE0 0x28 Icon                        ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemBase                               = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 024664C21C00 0x30 ImgItemBase                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemFrame                              = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 024664C21C20 0x38 ImgItemFrame                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664C21C40 0x40 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 024664C21C60 0x48 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.AchievemntDetailCaller                    = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 024664C21C80 0x50 AchievemntDetailCaller      ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )

            return value;
        }
    }
}
