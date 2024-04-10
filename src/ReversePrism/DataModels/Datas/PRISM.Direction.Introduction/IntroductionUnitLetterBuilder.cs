using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018672E9D0 ModelClassType IntroductionUnitLetterView IntroductionUnitLetterView IntroductionUnitLetterView Pointer
    public partial class IntroductionUnitLetterBuilder : DataModel
    {
        public IntroductionUnitLetterView?              View                                    { get; set; }

        public static IntroductionUnitLetterBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterBuilder() { Pointer= p0 };

            value.View                                      = GetObject<IntroductionUnitLetterView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionUnitLetterView.FromPointer); // 02466B6D5A68 0x20 View                        ( 00018672E9D0 ModelClassType IntroductionUnitLetterView IntroductionUnitLetterView IntroductionUnitLetterView Pointer )

            return value;
        }
    }
}
