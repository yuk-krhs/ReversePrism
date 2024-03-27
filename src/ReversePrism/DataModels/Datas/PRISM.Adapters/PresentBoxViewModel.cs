using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PresentViewModelList                     000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer
    // 018 HistoryViewModelList                     000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer
    // 020 PageCursor                               000186671910 ModelPrimitiveType string string string String
    // 028 ReceivePresentIdList                     000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class PresentBoxViewModel
    {
        public List<PresentBoxListViewModel>?           PresentViewModelList                    { get; set; }
        public List<PresentBoxListViewModel>?           HistoryViewModelList                    { get; set; }
        public string                                   PageCursor                              { get; set; }
        public List<string>?                            ReceivePresentIdList                    { get; set; }

        public static PresentBoxViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxViewModel();

            value.PresentViewModelList                      = GetObjectList<PresentBoxListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.PresentBoxListViewModel.FromPointer); // 0270D61F1568 0x10 PresentViewModelList        ( 000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer )
            value.HistoryViewModelList                      = GetObjectList<PresentBoxListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PresentBoxListViewModel.FromPointer); // 0270D61F1588 0x18 HistoryViewModelList        ( 000185CFAE08 ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer )
            value.PageCursor                                = GetString(new IntPtr(p + 0x020)); // 0270D61F15A8 0x20 PageCursor                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ReceivePresentIdList                      = GetStringList(new IntPtr(p + 0x028)); // 0270D61F15C8 0x28 ReceivePresentIdList        ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
