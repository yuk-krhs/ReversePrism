using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CrashlyticsInternal                      000186596740 ModelClassType FirebaseCrashlyticsInternal FirebaseCrashlyticsInternal FirebaseCrashlyticsInternal Pointer
    // 018 FirebaseApp                              000186595220 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer
    public partial class AndroidImpl : DataModel
    {
        public FirebaseCrashlyticsInternal?             CrashlyticsInternal                     { get; set; }
        public FirebaseApp?                             FirebaseApp                             { get; set; }

        public static AndroidImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidImpl() { Pointer= p0 };

            value.CrashlyticsInternal                       = GetObject<FirebaseCrashlyticsInternal>(new IntPtr(p + 0x010), ReversePrism.DataModels.FirebaseCrashlyticsInternal.FromPointer); // 02466BCE12C0 0x10 CrashlyticsInternal         ( 000186596740 ModelClassType FirebaseCrashlyticsInternal FirebaseCrashlyticsInternal FirebaseCrashlyticsInternal Pointer )
            value.FirebaseApp                               = GetObject<FirebaseApp>(new IntPtr(p + 0x018), ReversePrism.DataModels.FirebaseApp.FromPointer); // 02466BCE12E0 0x18 FirebaseApp                 ( 000186595220 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer )

            return value;
        }
    }
}
