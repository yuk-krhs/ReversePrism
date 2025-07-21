using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Analytics                              ModelClassType IAnalyticsClient IAnalyticsClient IAnalyticsClient Pointer
    // 018 M_ForwardTo                              ModelClassType IStoreListener IStoreListener IStoreListener Pointer
    // 020 M_Extensions                             ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer
    public partial class StoreListenerProxy : DataModel
    {
        public IAnalyticsClient?                        M_Analytics                             { get; set; }
        public IStoreListener?                          M_ForwardTo                             { get; set; }
        public IExtensionProvider?                      M_Extensions                            { get; set; }

        public static StoreListenerProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreListenerProxy() { Pointer= p0 };

            value.M_Analytics                               = GetObject<IAnalyticsClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnalyticsClient.FromPointer); // 0x10 M_Analytics                 ( ModelClassType IAnalyticsClient IAnalyticsClient IAnalyticsClient Pointer )
            value.M_ForwardTo                               = GetObject<IStoreListener>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoreListener.FromPointer); // 0x18 M_ForwardTo                 ( ModelClassType IStoreListener IStoreListener IStoreListener Pointer )
            value.M_Extensions                              = GetObject<IExtensionProvider>(new IntPtr(p + 0x020), ReversePrism.DataModels.IExtensionProvider.FromPointer); // 0x20 M_Extensions                ( ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer )

            return value;
        }
    }
}
