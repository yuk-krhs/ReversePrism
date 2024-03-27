using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HistoryListItems                         000185CDA768 ModelClassListType List`1<ExchangeHistoryItemViewModel> List`1<ExchangeHistoryItemViewModel> List<ExchangeHistoryItemViewModel> Pointer
    // 018 CurrentTabType                           000186640E10 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
    public partial class ExchangeHistoryViewModel
    {
        public List<ExchangeHistoryItemViewModel>?      HistoryListItems                        { get; set; }
        public ExchangeTabType                          CurrentTabType                          { get; set; }

        public static ExchangeHistoryViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryViewModel();

            value.HistoryListItems                          = GetObjectList<ExchangeHistoryItemViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeHistoryItemViewModel.FromPointer); // 0270D62BD148 0x10 HistoryListItems            ( 000185CDA768 ModelClassListType List`1<ExchangeHistoryItemViewModel> List`1<ExchangeHistoryItemViewModel> List<ExchangeHistoryItemViewModel> Pointer )
            value.CurrentTabType                            = (ExchangeTabType)GetInt32(new IntPtr(p + 0x018)); // 0270D62BD168 0x18 CurrentTabType              ( 000186640E10 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
