using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Label                                    0001865F7700 ModelPrimitiveType long long long Int64
    public partial class AddressablesRow
    {
        public long                                     Name                                    { get; set; }
        public long                                     Label                                   { get; set; }

        public static AddressablesRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddressablesRow();

            value.Name                                      = GetInt64(new IntPtr(p + 0x010)); // 027003E02FF8 0x10 Name                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Label                                     = GetInt64(new IntPtr(p + 0x018)); // 027003E03018 0x18 Label                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
