using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018657CD80 ModelClassType ChallengeTourResultView ChallengeTourResultView ChallengeTourResultView Pointer
    public partial class ChallengeTourResultBuilder
    {
        public ChallengeTourResultView?                 View                                    { get; set; }

        public static ChallengeTourResultBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultBuilder();

            value.View                                      = GetObject<ChallengeTourResultView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourResultView.FromPointer); // 0270DB61E4D8 0x20 View                        ( 00018657CD80 ModelClassType ChallengeTourResultView ChallengeTourResultView ChallengeTourResultView Pointer )

            return value;
        }
    }
}
