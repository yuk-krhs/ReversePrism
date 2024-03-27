using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetHavingItemAllArgs    Marshaller`1<GetHavingItemAllArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetHavingItemAllReply   Marshaller`1<GetHavingItemAllReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetProductDetailArgs    Marshaller`1<GetProductDetailArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetProductDetailReply   Marshaller`1<GetProductDetailReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetHavingItemAll                Method`2<GetHavingItemAllArgs, GetHavingItemAllReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_GetProductDetail                Method`2<GetProductDetailArgs, GetProductDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class ProductService
    {

        public static ProductService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductService();


            return value;
        }
    }
}
