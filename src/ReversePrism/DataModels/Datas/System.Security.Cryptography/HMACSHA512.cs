using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 M_useLegacyBlockSize                     ModelPrimitiveType bool bool bool Bool
    public partial class HMACSHA512 : DataModel
    {
        public bool                                     M_useLegacyBlockSize                    { get; set; }

        public static HMACSHA512? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HMACSHA512() { Pointer= p0 };

            value.M_useLegacyBlockSize                      = GetBool(new IntPtr(p + 0x068)); // 0x68 M_useLegacyBlockSize        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
