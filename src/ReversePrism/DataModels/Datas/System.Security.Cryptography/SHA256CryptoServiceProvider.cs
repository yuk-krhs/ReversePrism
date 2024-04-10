using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    sbyte[] IL2CPP_TYPE_SZARRAY
    // 028 Hash                                     0001866AE420 ModelClassType SHA256 SHA256 SHA256 Pointer
    public partial class SHA256CryptoServiceProvider : DataModel
    {
        public SHA256?                                  Hash                                    { get; set; }

        public static SHA256CryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA256CryptoServiceProvider() { Pointer= p0 };

            value.Hash                                      = GetObject<SHA256>(new IntPtr(p + 0x028), ReversePrism.DataModels.SHA256.FromPointer); // 0245A3D2AF50 0x28 Hash                        ( 0001866AE420 ModelClassType SHA256 SHA256 SHA256 Pointer )

            return value;
        }
    }
}
