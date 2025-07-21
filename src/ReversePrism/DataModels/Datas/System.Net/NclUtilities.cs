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
    // 010 LocalDomainName                          ModelPrimitiveType string string string String
    public partial class NclUtilities : DataModel
    {
        public string                                   LocalDomainName                         { get; set; }

        public static NclUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NclUtilities() { Pointer= p0 };

            value.LocalDomainName                           = GetString(new IntPtr(p + 0x010)); // 0x10 LocalDomainName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
