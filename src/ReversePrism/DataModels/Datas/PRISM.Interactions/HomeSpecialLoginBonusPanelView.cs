using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentSheetPanelView                    0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer
    // 028 NextSheetPanelView                       0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer
    // 030 RotationAnimator                         0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 ViewModel                                0001866C49A0 ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer
    public partial class HomeSpecialLoginBonusPanelView : DataModel
    {
        public HomeLoginBonusSheetPanelView?            CurrentSheetPanelView                   { get; set; }
        public HomeLoginBonusSheetPanelView?            NextSheetPanelView                      { get; set; }
        public Animator?                                RotationAnimator                        { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public HomeLoginBonusViewModel?                 ViewModel                               { get; set; }

        public static HomeSpecialLoginBonusPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSpecialLoginBonusPanelView() { Pointer= p0 };

            value.CurrentSheetPanelView                     = GetObject<HomeLoginBonusSheetPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeLoginBonusSheetPanelView.FromPointer); // 02466B5A7EE8 0x20 CurrentSheetPanelView       ( 0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer )
            value.NextSheetPanelView                        = GetObject<HomeLoginBonusSheetPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeLoginBonusSheetPanelView.FromPointer); // 02466B5A7F08 0x28 NextSheetPanelView          ( 0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer )
            value.RotationAnimator                          = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 02466B5A7F28 0x30 RotationAnimator            ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B5A7F48 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<HomeLoginBonusViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 02466B5A7F68 0x40 ViewModel                   ( 0001866C49A0 ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer )

            return value;
        }
    }
}
