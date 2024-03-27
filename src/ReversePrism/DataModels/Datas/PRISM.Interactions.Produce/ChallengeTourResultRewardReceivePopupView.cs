using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReceiveListView                          00018657BD40 ModelClassType ChallengeTourResultRewardReceiveListView ChallengeTourResultRewardReceiveListView ChallengeTourResultRewardReceiveListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ReceiveModelList                         000185CD1928 ModelClassListType List`1<ChallengeTourRewardViewModel> List`1<ChallengeTourRewardViewModel> List<ChallengeTourRewardViewModel> Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourResultRewardReceivePopupView
    {
        public ChallengeTourResultRewardReceiveListView? ReceiveListView                         { get; set; }
        public List<ChallengeTourRewardViewModel>?      ReceiveModelList                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourResultRewardReceivePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultRewardReceivePopupView();

            value.ReceiveListView                           = GetObject<ChallengeTourResultRewardReceiveListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourResultRewardReceiveListView.FromPointer); // 0270DA1BFBB0 0x20 ReceiveListView             ( 00018657BD40 ModelClassType ChallengeTourResultRewardReceiveListView ChallengeTourResultRewardReceiveListView ChallengeTourResultRewardReceiveListView Pointer )
            value.ReceiveModelList                          = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 0270DA1BFBF0 0x30 ReceiveModelList            ( 000185CD1928 ModelClassListType List`1<ChallengeTourRewardViewModel> List`1<ChallengeTourRewardViewModel> List<ChallengeTourRewardViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA1BFC10 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
