using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IgnoreCase                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class OrdinalComparer
    {
        public bool                                     IgnoreCase                              { get; set; }

        public static OrdinalComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrdinalComparer();

            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x010)); // 027003CC88E8 0x10 IgnoreCase                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
