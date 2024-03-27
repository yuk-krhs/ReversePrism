using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Store                                  0001866587B0 ModelClassType IStore IStore IStore Pointer
    // 018 M_Listener                               000186585300 ModelClassType IInternalStoreListener IInternalStoreListener IInternalStoreListener Pointer
    // 020 M_Logger                                 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer
    // 028 M_TransactionLog                         0001866A11C0 ModelClassType TransactionLog TransactionLog TransactionLog Pointer
    // 030 M_StoreName                              000186672F10 ModelPrimitiveType string string string String
    // 038 M_UnityServicesInitializationChecker     00018668B560 ModelClassType IUnityServicesInitializationChecker IUnityServicesInitializationChecker IUnityServicesInitializationChecker Pointer
    // 040 M_AdditionalProductsCallback             0001866792B0 ModelClassType Action Action Action Pointer
    // 048 m_AdditionalProductsFailCallback         Action`1<InitializationFailureReason> IL2CPP_TYPE_GENERICINST
    // 050 m_AdditionalProductsDetailedFailCallback Action`2<InitializationFailureReason, string> IL2CPP_TYPE_GENERICINST
    // 058 purchasesProcessedInSession              HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 060 UseTransactionLog                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 Products                                 00018659FC80 ModelClassType ProductCollection ProductCollection ProductCollection Pointer
    // 070 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PurchasingManager
    {
        public IStore?                                  M_Store                                 { get; set; }
        public IInternalStoreListener?                  M_Listener                              { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public TransactionLog?                          M_TransactionLog                        { get; set; }
        public string                                   M_StoreName                             { get; set; }
        public IUnityServicesInitializationChecker?     M_UnityServicesInitializationChecker    { get; set; }
        public Action?                                  M_AdditionalProductsCallback            { get; set; }
        public bool                                     UseTransactionLog                       { get; set; }
        public ProductCollection?                       Products                                { get; set; }
        public bool                                     Initialized                             { get; set; }

        public static PurchasingManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchasingManager();

            value.M_Store                                   = GetObject<IStore>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStore.FromPointer); // 027004BE13E0 0x10 M_Store                     ( 0001866587B0 ModelClassType IStore IStore IStore Pointer )
            value.M_Listener                                = GetObject<IInternalStoreListener>(new IntPtr(p + 0x018), ReversePrism.DataModels.IInternalStoreListener.FromPointer); // 027004BE1400 0x18 M_Listener                  ( 000186585300 ModelClassType IInternalStoreListener IInternalStoreListener IInternalStoreListener Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILogger.FromPointer); // 027004BE1420 0x20 M_Logger                    ( 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer )
            value.M_TransactionLog                          = GetObject<TransactionLog>(new IntPtr(p + 0x028), ReversePrism.DataModels.TransactionLog.FromPointer); // 027004BE1440 0x28 M_TransactionLog            ( 0001866A11C0 ModelClassType TransactionLog TransactionLog TransactionLog Pointer )
            value.M_StoreName                               = GetString(new IntPtr(p + 0x030)); // 027004BE1460 0x30 M_StoreName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_UnityServicesInitializationChecker      = GetObject<IUnityServicesInitializationChecker>(new IntPtr(p + 0x038), ReversePrism.DataModels.IUnityServicesInitializationChecker.FromPointer); // 027004BE1480 0x38 M_UnityServicesInitializationChecker ( 00018668B560 ModelClassType IUnityServicesInitializationChecker IUnityServicesInitializationChecker IUnityServicesInitializationChecker Pointer )
            value.M_AdditionalProductsCallback              = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 027004BE14A0 0x40 M_AdditionalProductsCallback ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.UseTransactionLog                         = GetBool(new IntPtr(p + 0x060)); // 027004BE1520 0x60 UseTransactionLog           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Products                                  = GetObject<ProductCollection>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProductCollection.FromPointer); // 027004BE1540 0x68 Products                    ( 00018659FC80 ModelClassType ProductCollection ProductCollection ProductCollection Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x070)); // 027004BE1560 0x70 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
