using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidPurchaseListenerClassName       string IL2CPP_TYPE_STRING
    // 020 M_LastKnownProductService                00018655C890 ModelClassType IGoogleLastKnownProductService IGoogleLastKnownProductService IGoogleLastKnownProductService Pointer
    // 028 M_GooglePurchaseCallback                 000186560F00 ModelClassType IGooglePurchaseCallback IGooglePurchaseCallback IGooglePurchaseCallback Pointer
    // 030 M_PurchaseBuilder                        0001865609D0 ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer
    // 038 M_GoogleCachedQuerySkuDetailsService     00018655B990 ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer
    // 040 M_GooglePurchaseStateEnumProvider        0001865618B0 ModelClassType IGooglePurchaseStateEnumProvider IGooglePurchaseStateEnumProvider IGooglePurchaseStateEnumProvider Pointer
    // 048 M_GoogleQueryPurchasesService            000186562050 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer
    public partial class GooglePurchaseUpdatedListener : DataModel
    {
        public IGoogleLastKnownProductService?          M_LastKnownProductService               { get; set; }
        public IGooglePurchaseCallback?                 M_GooglePurchaseCallback                { get; set; }
        public IGooglePurchaseBuilder?                  M_PurchaseBuilder                       { get; set; }
        public IGoogleCachedQuerySkuDetailsService?     M_GoogleCachedQuerySkuDetailsService    { get; set; }
        public IGooglePurchaseStateEnumProvider?        M_GooglePurchaseStateEnumProvider       { get; set; }
        public IGoogleQueryPurchasesService?            M_GoogleQueryPurchasesService           { get; set; }

        public static GooglePurchaseUpdatedListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchaseUpdatedListener() { Pointer= p0 };

            value.M_LastKnownProductService                 = GetObject<IGoogleLastKnownProductService>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGoogleLastKnownProductService.FromPointer); // 0245A68C9010 0x20 M_LastKnownProductService   ( 00018655C890 ModelClassType IGoogleLastKnownProductService IGoogleLastKnownProductService IGoogleLastKnownProductService Pointer )
            value.M_GooglePurchaseCallback                  = GetObject<IGooglePurchaseCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.IGooglePurchaseCallback.FromPointer); // 0245A68C9030 0x28 M_GooglePurchaseCallback    ( 000186560F00 ModelClassType IGooglePurchaseCallback IGooglePurchaseCallback IGooglePurchaseCallback Pointer )
            value.M_PurchaseBuilder                         = GetObject<IGooglePurchaseBuilder>(new IntPtr(p + 0x030), ReversePrism.DataModels.IGooglePurchaseBuilder.FromPointer); // 0245A68C9050 0x30 M_PurchaseBuilder           ( 0001865609D0 ModelClassType IGooglePurchaseBuilder IGooglePurchaseBuilder IGooglePurchaseBuilder Pointer )
            value.M_GoogleCachedQuerySkuDetailsService      = GetObject<IGoogleCachedQuerySkuDetailsService>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGoogleCachedQuerySkuDetailsService.FromPointer); // 0245A68C9070 0x38 M_GoogleCachedQuerySkuDetailsService ( 00018655B990 ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer )
            value.M_GooglePurchaseStateEnumProvider         = GetObject<IGooglePurchaseStateEnumProvider>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGooglePurchaseStateEnumProvider.FromPointer); // 0245A68C9090 0x40 M_GooglePurchaseStateEnumProvider ( 0001865618B0 ModelClassType IGooglePurchaseStateEnumProvider IGooglePurchaseStateEnumProvider IGooglePurchaseStateEnumProvider Pointer )
            value.M_GoogleQueryPurchasesService             = GetObject<IGoogleQueryPurchasesService>(new IntPtr(p + 0x048), ReversePrism.DataModels.IGoogleQueryPurchasesService.FromPointer); // 0245A68C90B0 0x48 M_GoogleQueryPurchasesService ( 000186562050 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer )

            return value;
        }
    }
}
