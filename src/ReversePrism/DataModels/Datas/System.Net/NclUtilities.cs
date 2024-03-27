using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _LocalAddresses                          IPAddress[] IL2CPP_TYPE_SZARRAY
    // 008 _LocalAddressesLock                      <object> IL2CPP_TYPE_OBJECT
    // 010 LocalDomainName                          0001866727E0 ModelPrimitiveType string string string String
    public partial class NclUtilities
    {
        public string                                   LocalDomainName                         { get; set; }

        public static NclUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NclUtilities();

            value.LocalDomainName                           = GetString(new IntPtr(p + 0x010)); // 0270D7A2BCF8 0x10 LocalDomainName             ( 0001866727E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
