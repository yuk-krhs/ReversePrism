using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 BonusItems                               IReadOnlyCollection`1<ShopGoodsParam> IL2CPP_TYPE_GENERICINST
    // 098 PurchaseCountThisTime                    ModelPrimitiveType int int int Int32
    public partial class Params : DataModel
    {
        public int                                      PurchaseCountThisTime                   { get; set; }

        public static Params? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Params() { Pointer= p0 };

            value.PurchaseCountThisTime                     = GetInt32(new IntPtr(p + 0x098)); // 0x98 PurchaseCountThisTime       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
