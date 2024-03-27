using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 TitleImage                               0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 LoginBonusRewardItemIcons                000185B84730 ModelClassListType HomeLoginBonusRewardItemIcon[] HomeLoginBonusRewardItemIcon[] List<HomeLoginBonusRewardItemIcon> Pointer
    // 038 PeriodText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GraffitiImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 TitleAnimator                            0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class HomeLoginBonusSheetPanelView
    {
        public UIImage?                                 BackgroundImage                         { get; set; }
        public UIImage?                                 TitleImage                              { get; set; }
        public List<HomeLoginBonusRewardItemIcon>?      LoginBonusRewardItemIcons               { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }
        public UIImage?                                 GraffitiImage                           { get; set; }
        public Animator?                                TitleAnimator                           { get; set; }

        public static HomeLoginBonusSheetPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusSheetPanelView();

            value.BackgroundImage                           = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB5090E8 0x20 BackgroundImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleImage                                = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB509108 0x28 TitleImage                  ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.LoginBonusRewardItemIcons                 = GetObjectList<HomeLoginBonusRewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeLoginBonusRewardItemIcon.FromPointer); // 0270DB509128 0x30 LoginBonusRewardItemIcons   ( 000185B84730 ModelClassListType HomeLoginBonusRewardItemIcon[] HomeLoginBonusRewardItemIcon[] List<HomeLoginBonusRewardItemIcon> Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB509148 0x38 PeriodText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GraffitiImage                             = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB509168 0x40 GraffitiImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleAnimator                             = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0270DB509188 0x48 TitleAnimator               ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
