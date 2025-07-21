using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Hdr                                      ModelPrimitiveType bool bool bool Bool
    // 029 ShowAlpha                                ModelPrimitiveType bool bool bool Bool
    // 02A ShowEyeDropper                           ModelPrimitiveType bool bool bool Bool
    public partial class NoInterpColorParameter : DataModel
    {
        public bool                                     Hdr                                     { get; set; }
        public bool                                     ShowAlpha                               { get; set; }
        public bool                                     ShowEyeDropper                          { get; set; }

        public static NoInterpColorParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoInterpColorParameter() { Pointer= p0 };

            value.Hdr                                       = GetBool(new IntPtr(p + 0x028)); // 0x28 Hdr                         ( ModelPrimitiveType bool bool bool Bool )
            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x029)); // 0x29 ShowAlpha                   ( ModelPrimitiveType bool bool bool Bool )
            value.ShowEyeDropper                            = GetBool(new IntPtr(p + 0x02A)); // 0x2A ShowEyeDropper              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
