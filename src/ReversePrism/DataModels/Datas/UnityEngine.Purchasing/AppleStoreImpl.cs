using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 m_DeferredCallback                       Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 068 m_RevokedCallback                        Action`1<List`1<Product>> IL2CPP_TYPE_GENERICINST
    // 070 m_RefreshReceiptError                    Action`1<string> IL2CPP_TYPE_GENERICINST
    // 078 m_RefreshReceiptSuccess                  Action`1<string> IL2CPP_TYPE_GENERICINST
    // 080 m_ObsoleteRestoreCallback                Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 088 m_RestoreCallback                        Action`2<bool, string> IL2CPP_TYPE_GENERICINST
    // 090 M_FetchStorePromotionOrderError          0001866792B0 ModelClassType Action Action Action Pointer
    // 098 m_FetchStorePromotionOrderSuccess        Action`1<List`1<Product>> IL2CPP_TYPE_GENERICINST
    // 0A0 m_PromotionalPurchaseCallback            Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 0A8 M_FetchStorePromotionVisibilityError     0001866792B0 ModelClassType Action Action Action Pointer
    // 0B0 m_FetchStorePromotionVisibilitySuccess   Action`2<string, AppleStorePromotionVisibility> IL2CPP_TYPE_GENERICINST
    // 0B8 M_Native                                 0001865BC340 ModelClassType INativeAppleStore INativeAppleStore INativeAppleStore Pointer
    // 0C0 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    // 000 s_Util                                   IUtil IL2CPP_TYPE_CLASS
    // 008 s_Instance                               AppleStoreImpl IL2CPP_TYPE_CLASS
    // 0C8 M_CachedAppReceipt                       000186671910 ModelPrimitiveType string string string String
    // 0D0 m_CachedAppReceiptModificationDate       Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 0E0 M_ProductsJson                           000186671910 ModelPrimitiveType string string string String
    public partial class AppleStoreImpl
    {
        public Action?                                  M_FetchStorePromotionOrderError         { get; set; }
        public Action?                                  M_FetchStorePromotionVisibilityError    { get; set; }
        public INativeAppleStore?                       M_Native                                { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }
        public string                                   M_CachedAppReceipt                      { get; set; }
        public string                                   M_ProductsJson                          { get; set; }

        public static AppleStoreImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppleStoreImpl();

            value.M_FetchStorePromotionOrderError           = GetObject<Action>(new IntPtr(p + 0x090), ReversePrism.DataModels.Action.FromPointer); // 027006915248 0x90 M_FetchStorePromotionOrderError ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_FetchStorePromotionVisibilityError      = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0270069152A8 0xA8 M_FetchStorePromotionVisibilityError ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_Native                                  = GetObject<INativeAppleStore>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.INativeAppleStore.FromPointer); // 0270069152E8 0xB8 M_Native                    ( 0001865BC340 ModelClassType INativeAppleStore INativeAppleStore INativeAppleStore Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 027006915308 0xC0 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )
            value.M_CachedAppReceipt                        = GetString(new IntPtr(p + 0x0C8)); // 027006915368 0xC8 M_CachedAppReceipt          ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ProductsJson                            = GetString(new IntPtr(p + 0x0E0)); // 0270069153A8 0xE0 M_ProductsJson              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
