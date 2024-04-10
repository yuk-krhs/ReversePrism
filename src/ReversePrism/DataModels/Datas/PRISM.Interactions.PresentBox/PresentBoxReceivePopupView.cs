using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReceiveListView                          000186509690 ModelClassType PresentBoxReceiveListView PresentBoxReceiveListView PresentBoxReceiveListView Pointer
    // 028 MessageText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 ReceiveModelList                         000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PresentBoxReceivePopupView : DataModel
    {
        public PresentBoxReceiveListView?               ReceiveListView                         { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public List<PresentBoxListViewModel>?           ReceiveModelList                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PresentBoxReceivePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxReceivePopupView() { Pointer= p0 };

            value.ReceiveListView                           = GetObject<PresentBoxReceiveListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PresentBoxReceiveListView.FromPointer); // 02466BF13830 0x20 ReceiveListView             ( 000186509690 ModelClassType PresentBoxReceiveListView PresentBoxReceiveListView PresentBoxReceiveListView Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF13850 0x28 MessageText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReceiveModelList                          = GetObjectList<PresentBoxListViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.PresentBoxListViewModel.FromPointer); // 02466BF13890 0x38 ReceiveModelList            ( 000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BF138B0 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
