using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LsitView                                 000186583450 ModelClassType ChallengeTourStageMissionListView ChallengeTourStageMissionListView ChallengeTourStageMissionListView Pointer
    // 028 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModels                               000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourStageMissionInfoPopupView : DataModel
    {
        public ChallengeTourStageMissionListView?       LsitView                                { get; set; }
        public List<ChallengeTourRewardViewModel>?      ViewModels                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourStageMissionInfoPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageMissionInfoPopupView() { Pointer= p0 };

            value.LsitView                                  = GetObject<ChallengeTourStageMissionListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourStageMissionListView.FromPointer); // 02466A225660 0x20 LsitView                    ( 000186583450 ModelClassType ChallengeTourStageMissionListView ChallengeTourStageMissionListView ChallengeTourStageMissionListView Pointer )
            value.ViewModels                                = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 02466A2256A0 0x30 ViewModels                  ( 000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A2256C0 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
