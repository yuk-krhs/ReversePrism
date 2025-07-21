using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitSelectView                           ModelClassType IntroductionUnitSelectView IntroductionUnitSelectView IntroductionUnitSelectView Pointer
    public partial class IntroductionUnitLetterView : DataModel
    {
        public IntroductionUnitSelectView?              UnitSelectView                          { get; set; }

        public static IntroductionUnitLetterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterView() { Pointer= p0 };

            value.UnitSelectView                            = GetObject<IntroductionUnitSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionUnitSelectView.FromPointer); // 0x20 UnitSelectView              ( ModelClassType IntroductionUnitSelectView IntroductionUnitSelectView IntroductionUnitSelectView Pointer )

            return value;
        }
    }
}
