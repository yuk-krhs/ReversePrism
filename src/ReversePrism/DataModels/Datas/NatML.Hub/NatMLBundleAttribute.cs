using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Identifier                               0001866736C0 ModelPrimitiveType string string string String
    public partial class NatMLBundleAttribute : DataModel
    {
        public string                                   Identifier                              { get; set; }

        public static NatMLBundleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NatMLBundleAttribute() { Pointer= p0 };

            value.Identifier                                = GetString(new IntPtr(p + 0x010)); // 02466BE3FC58 0x10 Identifier                  ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
