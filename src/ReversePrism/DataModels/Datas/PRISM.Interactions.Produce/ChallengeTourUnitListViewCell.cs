using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ChallengeTourUnitListViewCell : DataModel
    {
        public UIImage?                                 UnitIconImage                           { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ChallengeTourUnitListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitListViewCell() { Pointer= p0 };

            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 02466A23D878 0x40 UnitIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x048)); // 02466A23D898 0x48 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
