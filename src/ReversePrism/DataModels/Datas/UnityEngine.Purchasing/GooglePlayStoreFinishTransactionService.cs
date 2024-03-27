using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_ProcessedPurchaseToken                 HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 018 M_GooglePlayStoreService                 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    // 020 M_StoreCallback                          000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 028 M_RetryCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 k_MaxRetryAttempts                       int IL2CPP_TYPE_I4
    public partial class GooglePlayStoreFinishTransactionService
    {
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }
        public IStoreCallback?                          M_StoreCallback                         { get; set; }
        public int                                      M_RetryCount                            { get; set; }

        public static GooglePlayStoreFinishTransactionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStoreFinishTransactionService();

            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 02700690D660 0x18 M_GooglePlayStoreService    ( 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )
            value.M_StoreCallback                           = GetObject<IStoreCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreCallback.FromPointer); // 02700690D680 0x20 M_StoreCallback             ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_RetryCount                              = GetInt32(new IntPtr(p + 0x028)); // 02700690D6A0 0x28 M_RetryCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
