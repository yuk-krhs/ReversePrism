using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   00018672DDF0 ModelClassType IntroductionUnitLetterArgumentForLegacy IntroductionUnitLetterArgumentForLegacy IntroductionUnitLetterArgumentForLegacy Pointer
    public partial class IntroductionUnitLetterArgument : DataModel
    {
        public IntroductionUnitLetterArgumentForLegacy? Legacy                                  { get; set; }

        public static IntroductionUnitLetterArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterArgument() { Pointer= p0 };

            value.Legacy                                    = GetObject<IntroductionUnitLetterArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntroductionUnitLetterArgumentForLegacy.FromPointer); // 0246668A09B0 0x10 Legacy                      ( 00018672DDF0 ModelClassType IntroductionUnitLetterArgumentForLegacy IntroductionUnitLetterArgumentForLegacy IntroductionUnitLetterArgumentForLegacy Pointer )

            return value;
        }
    }
}
