using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186725970 ModelClassType IntroductionCharacterSelectView IntroductionCharacterSelectView IntroductionCharacterSelectView Pointer
    public partial class IntroductionCharacterSelectBuilder
    {
        public IntroductionCharacterSelectView?         View                                    { get; set; }

        public static IntroductionCharacterSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectBuilder();

            value.View                                      = GetObject<IntroductionCharacterSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionCharacterSelectView.FromPointer); // 0270DB61C7D0 0x20 View                        ( 000186725970 ModelClassType IntroductionCharacterSelectView IntroductionCharacterSelectView IntroductionCharacterSelectView Pointer )

            return value;
        }
    }
}
