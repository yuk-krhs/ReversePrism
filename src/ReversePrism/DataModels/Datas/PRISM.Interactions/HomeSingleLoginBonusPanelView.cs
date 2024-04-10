using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentSheetPanelView                    0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 ViewModel                                0001866C49A0 ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer
    public partial class HomeSingleLoginBonusPanelView : DataModel
    {
        public HomeLoginBonusSheetPanelView?            CurrentSheetPanelView                   { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public HomeLoginBonusViewModel?                 ViewModel                               { get; set; }

        public static HomeSingleLoginBonusPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSingleLoginBonusPanelView() { Pointer= p0 };

            value.CurrentSheetPanelView                     = GetObject<HomeLoginBonusSheetPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeLoginBonusSheetPanelView.FromPointer); // 02466B5A7B58 0x20 CurrentSheetPanelView       ( 0001866C4410 ModelClassType HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView HomeLoginBonusSheetPanelView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B5A7B78 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<HomeLoginBonusViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 02466B5A7B98 0x30 ViewModel                   ( 0001866C49A0 ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer )

            return value;
        }
    }
}
