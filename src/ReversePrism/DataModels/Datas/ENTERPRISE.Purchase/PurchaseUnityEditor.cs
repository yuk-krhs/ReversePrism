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
    public partial class PurchaseUnityEditor
    {
        public InitializeState                          InitializeState                         { get; set; }
        public BillingState                             BillingState                            { get; set; }

        public static PurchaseUnityEditor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityEditor();

            value.InitializeState                           = (InitializeState)GetInt32(new IntPtr(p + 0x010)); // 0270DBD47090 0x10 InitializeState             ( 000186682EA0 ModelEnumType InitializeState InitializeState InitializeState Int32 )
            value.BillingState                              = (BillingState)GetInt32(new IntPtr(p + 0x014)); // 0270DBD470B0 0x14 BillingState                ( 000186682750 ModelEnumType BillingState BillingState BillingState Int32 )

            return value;
        }
    }
}
