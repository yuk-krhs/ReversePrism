using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType long long long Int64
    // 018 Label                                    ModelPrimitiveType long long long Int64
    public partial class AddressablesRow : DataModel
    {
        public long                                     Name                                    { get; set; }
        public long                                     Label                                   { get; set; }

        public static AddressablesRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddressablesRow() { Pointer= p0 };

            value.Name                                      = GetInt64(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType long long long Int64 )
            value.Label                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Label                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
