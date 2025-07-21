using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 048 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveIdolGridCell : DataModel
    {
        public PFIdolIconView?                          IconView                                { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveIdolGridCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolGridCell() { Pointer= p0 };

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x40 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x048)); // 0x48 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
