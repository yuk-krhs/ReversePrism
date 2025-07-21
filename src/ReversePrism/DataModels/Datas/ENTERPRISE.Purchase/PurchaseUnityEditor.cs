using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitializeState                          ModelEnumType InitializeState InitializeState InitializeState Int32
    // 014 BillingState                             ModelEnumType BillingState BillingState BillingState Int32
    public partial class PurchaseUnityEditor : DataModel
    {
        public InitializeState                          InitializeState                         { get; set; }
        public BillingState                             BillingState                            { get; set; }

        public static PurchaseUnityEditor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityEditor() { Pointer= p0 };

            value.InitializeState                           = (InitializeState)GetInt32(new IntPtr(p + 0x010)); // 0x10 InitializeState             ( ModelEnumType InitializeState InitializeState InitializeState Int32 )
            value.BillingState                              = (BillingState)GetInt32(new IntPtr(p + 0x014)); // 0x14 BillingState                ( ModelEnumType BillingState BillingState BillingState Int32 )

            return value;
        }
    }
}
