using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayStoreService                 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    // 018 M_GoogleFetchPurchases                   00018655BEB0 ModelClassType IGoogleFetchPurchases IGoogleFetchPurchases IGoogleFetchPurchases Pointer
    // 020 M_StoreCallback                          000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 028 M_GooglePlayConfigurationInternal        00018655D510 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer
    // 030 M_GooglePlayStoreExtensions              00018655DCD0 ModelClassType IGooglePlayStoreExtensions IGooglePlayStoreExtensions IGooglePlayStoreExtensions Pointer
    // 038 M_HasInitiallyRetrievedProducts          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 M_RetrieveProductsFailed                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GooglePlayStoreRetrieveProductsService : DataModel
    {
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }
        public IGoogleFetchPurchases?                   M_GoogleFetchPurchases                  { get; set; }
        public IStoreCallback?                          M_StoreCallback                         { get; set; }
        public IGooglePlayConfigurationInternal?        M_GooglePlayConfigurationInternal       { get; set; }
        public IGooglePlayStoreExtensions?              M_GooglePlayStoreExtensions             { get; set; }
        public bool                                     M_HasInitiallyRetrievedProducts         { get; set; }
        public bool                                     M_RetrieveProductsFailed                { get; set; }

        public static GooglePlayStoreRetrieveProductsService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStoreRetrieveProductsService() { Pointer= p0 };

            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 0245A68D15B8 0x10 M_GooglePlayStoreService    ( 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )
            value.M_GoogleFetchPurchases                    = GetObject<IGoogleFetchPurchases>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGoogleFetchPurchases.FromPointer); // 0245A68D15D8 0x18 M_GoogleFetchPurchases      ( 00018655BEB0 ModelClassType IGoogleFetchPurchases IGoogleFetchPurchases IGoogleFetchPurchases Pointer )
            value.M_StoreCallback                           = GetObject<IStoreCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0245A68D15F8 0x20 M_StoreCallback             ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_GooglePlayConfigurationInternal         = GetObject<IGooglePlayConfigurationInternal>(new IntPtr(p + 0x028), ReversePrism.DataModels.IGooglePlayConfigurationInternal.FromPointer); // 0245A68D1618 0x28 M_GooglePlayConfigurationInternal ( 00018655D510 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer )
            value.M_GooglePlayStoreExtensions               = GetObject<IGooglePlayStoreExtensions>(new IntPtr(p + 0x030), ReversePrism.DataModels.IGooglePlayStoreExtensions.FromPointer); // 0245A68D1638 0x30 M_GooglePlayStoreExtensions ( 00018655DCD0 ModelClassType IGooglePlayStoreExtensions IGooglePlayStoreExtensions IGooglePlayStoreExtensions Pointer )
            value.M_HasInitiallyRetrievedProducts           = GetBool(new IntPtr(p + 0x038)); // 0245A68D1658 0x38 M_HasInitiallyRetrievedProducts ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RetrieveProductsFailed                  = GetBool(new IntPtr(p + 0x039)); // 0245A68D1678 0x39 M_RetrieveProductsFailed    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
