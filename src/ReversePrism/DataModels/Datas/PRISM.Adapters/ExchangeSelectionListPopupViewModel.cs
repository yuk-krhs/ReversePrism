using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LocalizationTextCategory                 string IL2CPP_TYPE_STRING
    // 010 TicketProduct                            ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 ExchangeSelectionListItemViewModels      ModelClassListType List`1<ExchangeSelectionListItemViewModel> List`1<ExchangeSelectionListItemViewModel> List<ExchangeSelectionListItemViewModel> Pointer
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 SelectedItemIndex                        ModelPrimitiveType int int int Int32
    public partial class ExchangeSelectionListPopupViewModel : DataModel
    {
        public IProductWithAmountStatus?                TicketProduct                           { get; set; }
        public List<ExchangeSelectionListItemViewModel>? ExchangeSelectionListItemViewModels     { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      SelectedItemIndex                       { get; set; }

        public static ExchangeSelectionListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionListPopupViewModel() { Pointer= p0 };

            value.TicketProduct                             = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 TicketProduct               ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ExchangeSelectionListItemViewModels       = GetObjectList<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0x18 ExchangeSelectionListItemViewModels ( ModelClassListType List`1<ExchangeSelectionListItemViewModel> List`1<ExchangeSelectionListItemViewModel> List<ExchangeSelectionListItemViewModel> Pointer )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SelectedItemIndex                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedItemIndex           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
