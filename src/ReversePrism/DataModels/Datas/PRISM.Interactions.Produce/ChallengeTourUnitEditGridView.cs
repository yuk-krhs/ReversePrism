using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ChallengeTourUnitEditGridViewCell ChallengeTourUnitEditGridViewCell ChallengeTourUnitEditGridViewCell Pointer
    public partial class ChallengeTourUnitEditGridView : DataModel
    {
        public ChallengeTourUnitEditGridViewCell?       CellPrefab                              { get; set; }

        public static ChallengeTourUnitEditGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ChallengeTourUnitEditGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ChallengeTourUnitEditGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ChallengeTourUnitEditGridViewCell ChallengeTourUnitEditGridViewCell ChallengeTourUnitEditGridViewCell Pointer )

            return value;
        }
    }
}
