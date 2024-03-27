using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Sha                                      0001866ADD00 ModelClassType SHA1Internal SHA1Internal SHA1Internal Pointer
    public partial class SHA1CryptoServiceProvider
    {
        public SHA1Internal?                            Sha                                     { get; set; }

        public static SHA1CryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA1CryptoServiceProvider();

            value.Sha                                       = GetObject<SHA1Internal>(new IntPtr(p + 0x028), ReversePrism.DataModels.SHA1Internal.FromPointer); // 027003E1D018 0x28 Sha                         ( 0001866ADD00 ModelClassType SHA1Internal SHA1Internal SHA1Internal Pointer )

            return value;
        }
    }
}
