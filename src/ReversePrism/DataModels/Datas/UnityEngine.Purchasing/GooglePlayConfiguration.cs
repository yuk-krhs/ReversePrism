using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_InitializationConnectionLister         0001866792B0 ModelClassType Action Action Action Pointer
    // 018 M_GooglePlayStoreService                 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    // 020 m_DeferredPurchaseAction                 Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 028 m_DeferredProrationUpgradeDowngradeSubscriptionAction Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 030 m_QueryProductDetailsFailedListener      Action`1<int> IL2CPP_TYPE_GENERICINST
    // 038 M_FetchPurchasesAtInitialize             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 M_FetchPurchasesExcludeDeferred          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GooglePlayConfiguration : DataModel
    {
        public Action?                                  M_InitializationConnectionLister        { get; set; }
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }
        public bool                                     M_FetchPurchasesAtInitialize            { get; set; }
        public bool                                     M_FetchPurchasesExcludeDeferred         { get; set; }

        public static GooglePlayConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayConfiguration() { Pointer= p0 };

            value.M_InitializationConnectionLister          = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0245A68CC138 0x10 M_InitializationConnectionLister ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 0245A68CC158 0x18 M_GooglePlayStoreService    ( 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )
            value.M_FetchPurchasesAtInitialize              = GetBool(new IntPtr(p + 0x038)); // 0245A68CC1D8 0x38 M_FetchPurchasesAtInitialize ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_FetchPurchasesExcludeDeferred           = GetBool(new IntPtr(p + 0x039)); // 0245A68CC1F8 0x39 M_FetchPurchasesExcludeDeferred ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
