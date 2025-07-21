using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Critical                                 ModelPrimitiveType bool bool bool Bool
    public partial class X509Extension : DataModel
    {
        public bool                                     Critical                                { get; set; }

        public static X509Extension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Extension() { Pointer= p0 };

            value.Critical                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 Critical                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
