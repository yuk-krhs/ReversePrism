using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Critical                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class X509Extension
    {
        public bool                                     Critical                                { get; set; }

        public static X509Extension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Extension();

            value.Critical                                  = GetBool(new IntPtr(p + 0x020)); // 0270D7980008 0x20 Critical                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
