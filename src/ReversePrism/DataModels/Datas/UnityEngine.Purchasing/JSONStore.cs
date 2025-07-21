using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unity                                    ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 M_Store                                  ModelClassType INativeStore INativeStore INativeStore Pointer
    // 020 M_StoreCatalog                           ModelClassListType List`1<ProductDefinition> List`1<ProductDefinition> List<ProductDefinition> Pointer
    // 028 M_IsRefreshing                           ModelPrimitiveType bool bool bool Bool
    // 030 M_RefreshCallback                        ModelClassType Action Action Action Pointer
    // 038 M_Module                                 ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer
    // 040 M_Logger                                 ModelClassType ILogger ILogger ILogger Pointer
    // 048 M_ProductDescriptionsDeserializer        ModelClassType JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer Pointer
    // 050 M_LastPurchaseFailureDescription         ModelClassType PurchaseFailureDescription PurchaseFailureDescription PurchaseFailureDescription Pointer
    // 058 M_LastPurchaseErrorCode                  ModelEnumType StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode Int32
    // 000 k_StoreSpecificErrorCodeKey              string IL2CPP_TYPE_STRING
    public partial class JSONStore : DataModel
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
            var value   = new JSONStore() { Pointer= p0 };

            value.Unity                                     = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0x10 Unity                       ( ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_Store                                   = GetObject<INativeStore>(new IntPtr(p + 0x018), ReversePrism.DataModels.INativeStore.FromPointer); // 0x18 M_Store                     ( ModelClassType INativeStore INativeStore INativeStore Pointer )
            value.M_StoreCatalog                            = GetObjectList<ProductDefinition>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductDefinition.FromPointer); // 0x20 M_StoreCatalog              ( ModelClassListType List`1<ProductDefinition> List`1<ProductDefinition> List<ProductDefinition> Pointer )
            value.M_IsRefreshing                            = GetBool(new IntPtr(p + 0x028)); // 0x28 M_IsRefreshing              ( ModelPrimitiveType bool bool bool Bool )
            value.M_RefreshCallback                         = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 M_RefreshCallback           ( ModelClassType Action Action Action Pointer )
            value.M_Module                                  = GetObject<StandardPurchasingModule>(new IntPtr(p + 0x038), ReversePrism.DataModels.StandardPurchasingModule.FromPointer); // 0x38 M_Module                    ( ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x040), ReversePrism.DataModels.ILogger.FromPointer); // 0x40 M_Logger                    ( ModelClassType ILogger ILogger ILogger Pointer )
            value.M_ProductDescriptionsDeserializer         = GetObject<JsonProductDescriptionsDeserializer>(new IntPtr(p + 0x048), ReversePrism.DataModels.JsonProductDescriptionsDeserializer.FromPointer); // 0x48 M_ProductDescriptionsDeserializer ( ModelClassType JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer JsonProductDescriptionsDeserializer Pointer )
            value.M_LastPurchaseFailureDescription          = GetObject<PurchaseFailureDescription>(new IntPtr(p + 0x050), ReversePrism.DataModels.PurchaseFailureDescription.FromPointer); // 0x50 M_LastPurchaseFailureDescription ( ModelClassType PurchaseFailureDescription PurchaseFailureDescription PurchaseFailureDescription Pointer )
            value.M_LastPurchaseErrorCode                   = (StoreSpecificPurchaseErrorCode)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_LastPurchaseErrorCode     ( ModelEnumType StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode StoreSpecificPurchaseErrorCode Int32 )

            return value;
        }
    }
}
