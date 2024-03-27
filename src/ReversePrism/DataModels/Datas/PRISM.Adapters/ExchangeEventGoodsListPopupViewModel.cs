using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventProductList                         000185CDB098 ModelClassListType List`1<ExchangeProductViewModel> List`1<ExchangeProductViewModel> List<ExchangeProductViewModel> Pointer
    // 018 ExchangeProduct                          0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 020 ExchangeProductAmount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExchangeEventGoodsListPopupViewModel
    {
        public List<ExchangeProductViewModel>?          EventProductList                        { get; set; }
        public IProductStatus?                          ExchangeProduct                         { get; set; }
        public int                                      ExchangeProductAmount                   { get; set; }

        public static ExchangeEventGoodsListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGoodsListPopupViewModel();

            value.EventProductList                          = GetObjectList<ExchangeProductViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0270D62BF4C0 0x10 EventProductList            ( 000185CDB098 ModelClassListType List`1<ExchangeProductViewModel> List`1<ExchangeProductViewModel> List<ExchangeProductViewModel> Pointer )
            value.ExchangeProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0270D62BF4E0 0x18 ExchangeProduct             ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ExchangeProductAmount                     = GetInt32(new IntPtr(p + 0x020)); // 0270D62BF500 0x20 ExchangeProductAmount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
