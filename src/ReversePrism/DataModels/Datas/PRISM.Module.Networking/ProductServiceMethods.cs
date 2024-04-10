using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetHavingItemAll                         Method`2<IGetHavingItemAllArgs, IGetHavingItemAllReply> IL2CPP_TYPE_GENERICINST
    // 018 GetProductDetail                         Method`2<IGetProductDetailArgs, IGetProductDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class ProductServiceMethods : DataModel
    {

        public static ProductServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
