using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 M_useLegacyBlockSize                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HMACSHA384 : DataModel
    {
        public bool                                     M_useLegacyBlockSize                    { get; set; }

        public static HMACSHA384? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HMACSHA384() { Pointer= p0 };

            value.M_useLegacyBlockSize                      = GetBool(new IntPtr(p + 0x068)); // 024661923E18 0x68 M_useLegacyBlockSize        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
