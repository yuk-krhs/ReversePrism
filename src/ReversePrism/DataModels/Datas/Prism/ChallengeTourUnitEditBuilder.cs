using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ChallengeTourUnitEditView ChallengeTourUnitEditView ChallengeTourUnitEditView Pointer
    public partial class ChallengeTourUnitEditBuilder : DataModel
    {
        public ChallengeTourUnitEditView?               View                                    { get; set; }

        public static ChallengeTourUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ChallengeTourUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditView.FromPointer); // 0x20 View                        ( ModelClassType ChallengeTourUnitEditView ChallengeTourUnitEditView ChallengeTourUnitEditView Pointer )

            return value;
        }
    }
}
