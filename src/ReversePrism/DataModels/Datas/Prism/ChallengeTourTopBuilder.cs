using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186588060 ModelClassType ChallengeTourTopView ChallengeTourTopView ChallengeTourTopView Pointer
    public partial class ChallengeTourTopBuilder
    {
        public ChallengeTourTopView?                    View                                    { get; set; }

        public static ChallengeTourTopBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopBuilder();

            value.View                                      = GetObject<ChallengeTourTopView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourTopView.FromPointer); // 0270DB61E5A8 0x20 View                        ( 000186588060 ModelClassType ChallengeTourTopView ChallengeTourTopView ChallengeTourTopView Pointer )

            return value;
        }
    }
}
