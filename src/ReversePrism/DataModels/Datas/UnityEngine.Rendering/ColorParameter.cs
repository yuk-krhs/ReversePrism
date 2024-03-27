using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Hdr                                      000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 029 ShowAlpha                                000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 02A ShowEyeDropper                           000186597BE0 ModelPrimitiveType bool bool bool Bool
    public partial class ColorParameter
    {
        public bool                                     Hdr                                     { get; set; }
        public bool                                     ShowAlpha                               { get; set; }
        public bool                                     ShowEyeDropper                          { get; set; }

        public static ColorParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorParameter();

            value.Hdr                                       = GetBool(new IntPtr(p + 0x028)); // 0270D9152F78 0x28 Hdr                         ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x029)); // 0270D9152F98 0x29 ShowAlpha                   ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.ShowEyeDropper                            = GetBool(new IntPtr(p + 0x02A)); // 0270D9152FB8 0x2A ShowEyeDropper              ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
