using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DressOrderTicketCountBefore              ModelPrimitiveType long long long Int64
    // 018 DressOrderTicketKey                      ModelEnumType ProductKey ProductKey ProductKey Int32
    public partial class ProduceIdolDressOrderModel : DataModel
    {
        public long                                     DressOrderTicketCountBefore             { get; set; }
        public ProductKey                               DressOrderTicketKey                     { get; set; }

        public static ProduceIdolDressOrderModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolDressOrderModel() { Pointer= p0 };

            value.DressOrderTicketCountBefore               = GetInt64(new IntPtr(p + 0x010)); // 0x10 DressOrderTicketCountBefore ( ModelPrimitiveType long long long Int64 )
            value.DressOrderTicketKey                       = (ProductKey)GetInt32(new IntPtr(p + 0x018)); // 0x18 DressOrderTicketKey         ( ModelEnumType ProductKey ProductKey ProductKey Int32 )

            return value;
        }
    }
}
