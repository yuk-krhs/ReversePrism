using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentSheetPanelView                    ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer
    // 028 NextSheetPanelView                       ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer
    // 030 RotationAnimator                         ModelClassType Animator Animator Animator Pointer
    // 038 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 ViewModel                                ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer
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

            value.CurrentSheetPanelView                     = GetObject<HomeLoginBonusSheetPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeLoginBonusSheetPanelView.FromPointer); // 0x20 CurrentSheetPanelView       ( ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer )
            value.NextSheetPanelView                        = GetObject<HomeLoginBonusSheetPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeLoginBonusSheetPanelView.FromPointer); // 0x28 NextSheetPanelView          ( ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer )
            value.RotationAnimator                          = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 RotationAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<HomeLoginBonusViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer )

            return value;
        }
    }
}
