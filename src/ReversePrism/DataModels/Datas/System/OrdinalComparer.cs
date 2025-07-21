using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IgnoreCase                               ModelPrimitiveType bool bool bool Bool
    public partial class OrdinalComparer : DataModel
    {
        public bool                                     IgnoreCase                              { get; set; }

        public static OrdinalComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrdinalComparer() { Pointer= p0 };

            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IgnoreCase                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
