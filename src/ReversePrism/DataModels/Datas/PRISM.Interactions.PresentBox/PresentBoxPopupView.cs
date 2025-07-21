using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PresentListView                          ModelClassType PresentBoxListView PresentBoxListView PresentBoxListView Pointer
    // 028 ReplaceTexts                             ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onOpenHistory                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onReceive                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PresentBoxPopupView : DataModel
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
            var value   = new PresentBoxPopupView() { Pointer= p0 };

            value.PresentListView                           = GetObject<PresentBoxListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PresentBoxListView.FromPointer); // 0x20 PresentListView             ( ModelClassType PresentBoxListView PresentBoxListView PresentBoxListView Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ReplaceTexts                ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ViewModel                                 = GetObject<PresentBoxViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.PresentBoxViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType PresentBoxViewModel PresentBoxViewModel PresentBoxViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
