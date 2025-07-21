using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Icon                                     ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 048 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class LiveEventRankingIdolSelectListCell : DataModel
    {
        public PFIdolIconView?                          Icon                                    { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static LiveEventRankingIdolSelectListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingIdolSelectListCell() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x40 Icon                        ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x48 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
