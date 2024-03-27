using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   0001866A5040 ModelClassType HableCurve HableCurve HableCurve Pointer
    public partial class Uniforms
    {
        public HableCurve?                              Parent                                  { get; set; }

        public static Uniforms? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Uniforms();

            value.Parent                                    = GetObject<HableCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.HableCurve.FromPointer); // 0270DB421220 0x10 Parent                      ( 0001866A5040 ModelClassType HableCurve HableCurve HableCurve Pointer )

            return value;
        }
    }
}
