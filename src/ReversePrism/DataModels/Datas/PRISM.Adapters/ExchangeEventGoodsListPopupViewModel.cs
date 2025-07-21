using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventProductList                         ModelClassListType List`1<ExchangeProductViewModel> List`1<ExchangeProductViewModel> List<ExchangeProductViewModel> Pointer
    // 018 ExchangeProduct                          ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 020 ExchangeProductAmount                    ModelPrimitiveType int int int Int32
    public partial class ExchangeEventGoodsListPopupViewModel : DataModel
    {
        public List<ExchangeProductViewModel>?          EventProductList                        { get; set; }
        public IProductStatus?                          ExchangeProduct                         { get; set; }
        public int                                      ExchangeProductAmount                   { get; set; }

        public static ExchangeEventGoodsListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGoodsListPopupViewModel() { Pointer= p0 };

            value.EventProductList                          = GetObjectList<ExchangeProductViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0x10 EventProductList            ( ModelClassListType List`1<ExchangeProductViewModel> List`1<ExchangeProductViewModel> List<ExchangeProductViewModel> Pointer )
            value.ExchangeProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x18 ExchangeProduct             ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ExchangeProductAmount                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 ExchangeProductAmount       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
