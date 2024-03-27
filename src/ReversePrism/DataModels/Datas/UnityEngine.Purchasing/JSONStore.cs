using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unity                                    000186658F10 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 M_Store                                  0001865BED00 ModelClassType INativeStore INativeStore INativeStore Pointer
    // 020 M_StoreCatalog                           000185CFDEB8 ModelClassListType List`1<ProductDefinition> List`1<ProductDefinition> List<ProductDefinition> Pointer
    // 028 M_IsRefreshing                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_RefreshCallback                        0001866792B0 ModelClassType Action Action Action Pointer
    // 038 M_Module                                 00018656C8F0 ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer
    // 040 M_Logger                                 0001865A12D0 ModelClassType ILogger ILogger ILogger Pointer
    // 048 M_ProductDescriptionsDeserializer        000186758CC0 ModelClassType JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer Pointer
    // 050 M_LastPurchaseFailureDescription         0001865DB700 ModelClassType PurchaseFailureDescription PurchaseFailureDescription PurchaseFailureDescription Pointer
    // 058 M_LastPurchaseErrorCode                  000186593E60 ModelEnumType StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode Int32
    // 000 k_StoreSpecificErrorCodeKey              string IL2CPP_TYPE_STRING
    public partial class JSONStore
    {
        public IStoreCallback?                          Unity                                   { get; set; }
        public INativeStore?                            M_Store                                 { get; set; }
        public List<ProductDefinition>?                 M_StoreCatalog                          { get; set; }
        public bool                                     M_IsRefreshing                          { get; set; }
        public Action?                                  M_RefreshCallback                       { get; set; }
        public StandardPurchasingModule?                M_Module                                { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public JsonProductDescriptionsDeserializer?     M_ProductDescriptionsDeserializer       { get; set; }
        public PurchaseFailureDescription?              M_LastPurchaseFailureDescription        { get; set; }
        public StoreSpecificPurchaseErrorCode           M_LastPurchaseErrorCode                 { get; set; }

        public static JSONStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JSONStore();

            value.Unity                                     = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0270069119B8 0x10 Unity                       ( 000186658F10 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_Store                                   = GetObject<INativeStore>(new IntPtr(p + 0x018), ReversePrism.DataModels.INativeStore.FromPointer); // 0270069119D8 0x18 M_Store                     ( 0001865BED00 ModelClassType INativeStore INativeStore INativeStore Pointer )
            value.M_StoreCatalog                            = GetObjectList<ProductDefinition>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductDefinition.FromPointer); // 0270069119F8 0x20 M_StoreCatalog              ( 000185CFDEB8 ModelClassListType List`1<ProductDefinition> List`1<ProductDefinition> List<ProductDefinition> Pointer )
            value.M_IsRefreshing                            = GetBool(new IntPtr(p + 0x028)); // 027006911A18 0x28 M_IsRefreshing              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RefreshCallback                         = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 027006911A38 0x30 M_RefreshCallback           ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_Module                                  = GetObject<StandardPurchasingModule>(new IntPtr(p + 0x038), ReversePrism.DataModels.StandardPurchasingModule.FromPointer); // 027006911A58 0x38 M_Module                    ( 00018656C8F0 ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x040), ReversePrism.DataModels.ILogger.FromPointer); // 027006911A78 0x40 M_Logger                    ( 0001865A12D0 ModelClassType ILogger ILogger ILogger Pointer )
            value.M_ProductDescriptionsDeserializer         = GetObject<JsonProductDescriptionsDeserializer>(new IntPtr(p + 0x048), ReversePrism.DataModels.JsonProductDescriptionsDeserializer.FromPointer); // 027006911A98 0x48 M_ProductDescriptionsDeserializer ( 000186758CC0 ModelClassType JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer Pointer )
            value.M_LastPurchaseFailureDescription          = GetObject<PurchaseFailureDescription>(new IntPtr(p + 0x050), ReversePrism.DataModels.PurchaseFailureDescription.FromPointer); // 027006911AB8 0x50 M_LastPurchaseFailureDescription ( 0001865DB700 ModelClassType PurchaseFailureDescription PurchaseFailureDescription PurchaseFailureDescription Pointer )
            value.M_LastPurchaseErrorCode                   = (StoreSpecificPurchaseErrorCode)GetInt32(new IntPtr(p + 0x058)); // 027006911AD8 0x58 M_LastPurchaseErrorCode     ( 000186593E60 ModelEnumType StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode Int32 )

            return value;
        }
    }
}
