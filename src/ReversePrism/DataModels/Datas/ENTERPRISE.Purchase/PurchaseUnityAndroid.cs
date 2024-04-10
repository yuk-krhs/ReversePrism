using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 GooglePlayStoreExtensions                00018655DA10 ModelClassType IGooglePlayStoreExtensions IGooglePlayStoreExtensions IGooglePlayStoreExtensions Pointer
    // 060 GooglePlayConfiguration                  00018655CD90 ModelClassType IGooglePlayConfiguration IGooglePlayConfiguration IGooglePlayConfiguration Pointer
    public partial class PurchaseUnityAndroid : DataModel
    {
        public IGooglePlayStoreExtensions?              GooglePlayStoreExtensions               { get; set; }
        public IGooglePlayConfiguration?                GooglePlayConfiguration                 { get; set; }

        public static PurchaseUnityAndroid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityAndroid() { Pointer= p0 };

            value.GooglePlayStoreExtensions                 = GetObject<IGooglePlayStoreExtensions>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGooglePlayStoreExtensions.FromPointer); // 02466BDD8578 0x58 GooglePlayStoreExtensions   ( 00018655DA10 ModelClassType IGooglePlayStoreExtensions IGooglePlayStoreExtensions IGooglePlayStoreExtensions Pointer )
            value.GooglePlayConfiguration                   = GetObject<IGooglePlayConfiguration>(new IntPtr(p + 0x060), ReversePrism.DataModels.IGooglePlayConfiguration.FromPointer); // 02466BDD8598 0x60 GooglePlayConfiguration     ( 00018655CD90 ModelClassType IGooglePlayConfiguration IGooglePlayConfiguration IGooglePlayConfiguration Pointer )

            return value;
        }
    }
}
