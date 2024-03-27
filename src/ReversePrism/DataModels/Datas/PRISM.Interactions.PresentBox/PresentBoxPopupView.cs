using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PresentListView                          000186779390 ModelClassType PresentBoxListView PresentBoxListView PresentBoxListView Pointer
    // 028 ReplaceTexts                             000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 receivePopupViewFactory                  PopupViewFactory`1<IPresentBoxReceivePopupView> IL2CPP_TYPE_GENERICINST
    // 038 historyPopupViewFactory                  PopupViewFactory`1<IPresentBoxHistoryPopupView> IL2CPP_TYPE_GENERICINST
    // 040 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onOpenHistory                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onReceive                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 ViewModel                                00018650A360 ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PresentBoxPopupView
    {
        public PresentBoxListView?                      PresentListView                         { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }
        public PresentBoxViewModel?                     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PresentBoxPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxPopupView();

            value.PresentListView                           = GetObject<PresentBoxListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PresentBoxListView.FromPointer); // 0270DBE81548 0x20 PresentListView             ( 000186779390 ModelClassType PresentBoxListView PresentBoxListView PresentBoxListView Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBE81568 0x28 ReplaceTexts                ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ViewModel                                 = GetObject<PresentBoxViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.PresentBoxViewModel.FromPointer); // 0270DBE81628 0x58 ViewModel                   ( 00018650A360 ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBE81648 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
