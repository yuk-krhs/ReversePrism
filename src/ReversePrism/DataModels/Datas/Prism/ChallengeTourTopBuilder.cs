using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ChallengeTourTopView ChallengeTourTopView ChallengeTourTopView Pointer
    public partial class ChallengeTourTopBuilder : DataModel
    {
        public ChallengeTourTopView?                    View                                    { get; set; }

        public static ChallengeTourTopBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ChallengeTourTopView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourTopView.FromPointer); // 0x20 View                        ( ModelClassType ChallengeTourTopView ChallengeTourTopView ChallengeTourTopView Pointer )

            return value;
        }
    }
}
