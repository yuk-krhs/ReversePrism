using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 PIdolIconView                            000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 038 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ChallengeTourPIdolSelectGridViewCell
    {
        public PFIdolIconView?                          PIdolIconView                           { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ChallengeTourPIdolSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolSelectGridViewCell();

            value.PIdolIconView                             = GetObject<PFIdolIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA1D2630 0x30 PIdolIconView               ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA1D2650 0x38 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
