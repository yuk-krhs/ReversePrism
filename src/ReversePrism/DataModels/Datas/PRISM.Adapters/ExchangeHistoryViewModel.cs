using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HistoryListItems                         ModelClassListType List`1<ExchangeHistoryItemViewModel> List`1<ExchangeHistoryItemViewModel> List<ExchangeHistoryItemViewModel> Pointer
    // 018 CurrentTabType                           ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
    public partial class ExchangeHistoryViewModel : DataModel
    {
        public List<ExchangeHistoryItemViewModel>?      HistoryListItems                        { get; set; }
        public ExchangeTabType                          CurrentTabType                          { get; set; }

        public static ExchangeHistoryViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryViewModel() { Pointer= p0 };

            value.HistoryListItems                          = GetObjectList<ExchangeHistoryItemViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeHistoryItemViewModel.FromPointer); // 0x10 HistoryListItems            ( ModelClassListType List`1<ExchangeHistoryItemViewModel> List`1<ExchangeHistoryItemViewModel> List<ExchangeHistoryItemViewModel> Pointer )
            value.CurrentTabType                            = (ExchangeTabType)GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentTabType              ( ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
