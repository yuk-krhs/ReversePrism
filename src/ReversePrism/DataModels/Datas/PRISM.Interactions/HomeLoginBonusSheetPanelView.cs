using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          ModelClassType UIImage UIImage UIImage Pointer
    // 028 TitleImage                               ModelClassType UIImage UIImage UIImage Pointer
    // 030 LoginBonusRewardItemIcons                ModelClassListType HomeLoginBonusRewardItemIcon[] HomeLoginBonusRewardItemIcon[] List<HomeLoginBonusRewardItemIcon> Pointer
    // 038 PeriodText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GraffitiImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 048 TitleAnimator                            ModelClassType Animator Animator Animator Pointer
    public partial class HomeLoginBonusSheetPanelView : DataModel
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
            var value   = new HomeLoginBonusSheetPanelView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BackgroundImage             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleImage                                = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 TitleImage                  ( ModelClassType UIImage UIImage UIImage Pointer )
            value.LoginBonusRewardItemIcons                 = GetObjectList<HomeLoginBonusRewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeLoginBonusRewardItemIcon.FromPointer); // 0x30 LoginBonusRewardItemIcons   ( ModelClassListType HomeLoginBonusRewardItemIcon[] HomeLoginBonusRewardItemIcon[] List<HomeLoginBonusRewardItemIcon> Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 PeriodText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GraffitiImage                             = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 GraffitiImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleAnimator                             = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 TitleAnimator               ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
