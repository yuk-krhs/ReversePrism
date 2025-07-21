using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PresentViewModelList                     ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer
    // 018 HistoryViewModelList                     ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer
    // 020 PageCursor                               ModelPrimitiveType string string string String
    // 028 ReceivePresentIdList                     ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class PresentBoxViewModel : DataModel
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
            var value   = new PresentBoxViewModel() { Pointer= p0 };

            value.PresentViewModelList                      = GetObjectList<PresentBoxListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.PresentBoxListViewModel.FromPointer); // 0x10 PresentViewModelList        ( ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer )
            value.HistoryViewModelList                      = GetObjectList<PresentBoxListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PresentBoxListViewModel.FromPointer); // 0x18 HistoryViewModelList        ( ModelClassListType List`1<PresentBoxListViewModel> List`1<PresentBoxListViewModel> List<PresentBoxListViewModel> Pointer )
            value.PageCursor                                = GetString(new IntPtr(p + 0x020)); // 0x20 PageCursor                  ( ModelPrimitiveType string string string String )
            value.ReceivePresentIdList                      = GetStringList(new IntPtr(p + 0x028)); // 0x28 ReceivePresentIdList        ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
