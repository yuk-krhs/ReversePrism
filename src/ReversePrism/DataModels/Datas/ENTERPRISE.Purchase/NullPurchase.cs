using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitializeState                          000186682EA0 ModelEnumType InitializeState InitializeState InitializeState Int32
    // 014 BillingState                             000186682750 ModelEnumType BillingState BillingState BillingState Int32
    public partial class NullPurchase : DataModel
    {
        public InitializeState                          InitializeState                         { get; set; }
        public BillingState                             BillingState                            { get; set; }

        public static NullPurchase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullPurchase() { Pointer= p0 };

            value.InitializeState                           = (InitializeState)GetInt32(new IntPtr(p + 0x010)); // 02466BDD9F18 0x10 InitializeState             ( 000186682EA0 ModelEnumType InitializeState InitializeState InitializeState Int32 )
            value.BillingState                              = (BillingState)GetInt32(new IntPtr(p + 0x014)); // 02466BDD9F38 0x14 BillingState                ( 000186682750 ModelEnumType BillingState BillingState BillingState Int32 )

            return value;
        }
    }
}
