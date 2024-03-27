using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HistoryListView                          000186778720 ModelClassType PresentBoxHistoryListView PresentBoxHistoryListView PresentBoxHistoryListView Pointer
    // 028 ReplaceTexts                             000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 ViewModel                                00018650A360 ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PresentBoxHistoryPopupView
    {
        public PresentBoxHistoryListView?               HistoryListView                         { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }
        public PresentBoxViewModel?                     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PresentBoxHistoryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxHistoryPopupView();

            value.HistoryListView                           = GetObject<PresentBoxHistoryListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PresentBoxHistoryListView.FromPointer); // 0270DBE7F4F8 0x20 HistoryListView             ( 000186778720 ModelClassType PresentBoxHistoryListView PresentBoxHistoryListView PresentBoxHistoryListView Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBE7F518 0x28 ReplaceTexts                ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ViewModel                                 = GetObject<PresentBoxViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.PresentBoxViewModel.FromPointer); // 0270DBE7F558 0x38 ViewModel                   ( 00018650A360 ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBE7F578 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
