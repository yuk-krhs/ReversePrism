using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TicketProduct                            0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 ExchangeSelectionListItemViewModels      000185CDB568 ModelClassListType List`1<ExchangeSelectionListItemViewModel> List`1<ExchangeSelectionListItemViewModel> List<ExchangeSelectionListItemViewModel> Pointer
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 CurrentProductType                       000186610E80 ModelEnumType ProductType ProductType ProductType Int32
    // 034 SelectedItemIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExchangeSelectionListPopupViewModel : DataModel
    {
        public IProductWithAmountStatus?                TicketProduct                           { get; set; }
        public List<ExchangeSelectionListItemViewModel>? ExchangeSelectionListItemViewModels     { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public ProductType                              CurrentProductType                      { get; set; }
        public int                                      SelectedItemIndex                       { get; set; }

        public static ExchangeSelectionListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionListPopupViewModel() { Pointer= p0 };

            value.TicketProduct                             = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024666347F58 0x10 TicketProduct               ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ExchangeSelectionListItemViewModels       = GetObjectList<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 024666347F78 0x18 ExchangeSelectionListItemViewModels ( 000185CDB568 ModelClassListType List`1<ExchangeSelectionListItemViewModel> List`1<ExchangeSelectionListItemViewModel> List<ExchangeSelectionListItemViewModel> Pointer )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 024666347F98 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CurrentProductType                        = (ProductType)GetInt32(new IntPtr(p + 0x030)); // 024666347FB8 0x30 CurrentProductType          ( 000186610E80 ModelEnumType ProductType ProductType ProductType Int32 )
            value.SelectedItemIndex                         = GetInt32(new IntPtr(p + 0x034)); // 024666347FD8 0x34 SelectedItemIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
