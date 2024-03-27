using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClickPurchase                          Subject`1<ExchangeLargeSpaceGoodsGridViewModel> IL2CPP_TYPE_GENERICINST
    // 048 LocalSave                                000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    public partial class ExchangeLargeSpaceGoodsViewContext
    {
        public ExchangeSaveData?                        LocalSave                               { get; set; }

        public static ExchangeLargeSpaceGoodsViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeLargeSpaceGoodsViewContext();

            value.LocalSave                                 = GetObject<ExchangeSaveData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 0270DB8C8088 0x48 LocalSave                   ( 000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )

            return value;
        }
    }
}
