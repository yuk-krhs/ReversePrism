using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018658AEF0 ModelClassType ChallengeTourUnitEditView ChallengeTourUnitEditView ChallengeTourUnitEditView Pointer
    public partial class ChallengeTourUnitEditBuilder
    {
        public ChallengeTourUnitEditView?               View                                    { get; set; }

        public static ChallengeTourUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditBuilder();

            value.View                                      = GetObject<ChallengeTourUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditView.FromPointer); // 0270DB61E870 0x20 View                        ( 00018658AEF0 ModelClassType ChallengeTourUnitEditView ChallengeTourUnitEditView ChallengeTourUnitEditView Pointer )

            return value;
        }
    }
}
