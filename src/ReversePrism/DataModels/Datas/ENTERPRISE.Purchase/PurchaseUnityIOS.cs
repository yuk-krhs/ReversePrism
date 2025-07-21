using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 AppleExtensions                          ModelClassType IAppleExtensions IAppleExtensions IAppleExtensions Pointer
    public partial class PurchaseUnityIOS : DataModel
    {
        public IAppleExtensions?                        AppleExtensions                         { get; set; }

        public static PurchaseUnityIOS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityIOS() { Pointer= p0 };

            value.AppleExtensions                           = GetObject<IAppleExtensions>(new IntPtr(p + 0x058), ReversePrism.DataModels.IAppleExtensions.FromPointer); // 0x58 AppleExtensions             ( ModelClassType IAppleExtensions IAppleExtensions IAppleExtensions Pointer )

            return value;
        }
    }
}
