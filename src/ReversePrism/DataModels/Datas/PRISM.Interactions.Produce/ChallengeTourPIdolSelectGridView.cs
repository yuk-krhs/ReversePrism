using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ChallengeTourPIdolSelectGridViewCell ChallengeTourPIdolSelectGridViewCell ChallengeTourPIdolSelectGridViewCell Pointer
    public partial class ChallengeTourPIdolSelectGridView : DataModel
    {
        public ChallengeTourPIdolSelectGridViewCell?    CellPrefab                              { get; set; }

        public static ChallengeTourPIdolSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ChallengeTourPIdolSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ChallengeTourPIdolSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ChallengeTourPIdolSelectGridViewCell ChallengeTourPIdolSelectGridViewCell ChallengeTourPIdolSelectGridViewCell Pointer )

            return value;
        }
    }
}
