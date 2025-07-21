using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StoreCallback                          ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 M_GooglePlayConfigurationInternal        ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer
    // 020 M_Util                                   ModelClassType IUtil IUtil IUtil Pointer
    public partial class GooglePlayPurchaseCallback : DataModel
    {
        public IStoreCallback?                          M_StoreCallback                         { get; set; }
        public IGooglePlayConfigurationInternal?        M_GooglePlayConfigurationInternal       { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static GooglePlayPurchaseCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayPurchaseCallback() { Pointer= p0 };

            value.M_StoreCallback                           = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0x10 M_StoreCallback             ( ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_GooglePlayConfigurationInternal         = GetObject<IGooglePlayConfigurationInternal>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePlayConfigurationInternal.FromPointer); // 0x18 M_GooglePlayConfigurationInternal ( ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUtil.FromPointer); // 0x20 M_Util                      ( ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
