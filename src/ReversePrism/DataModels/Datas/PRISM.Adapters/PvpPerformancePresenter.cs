using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001866089E0 ModelClassType IPvpPerformanceView IPvpPerformanceView IPvpPerformanceView Pointer
    // 018 Argument                                 0001865EC130 ModelClassType PvpPerformanceArgument PvpPerformanceArgument PvpPerformanceArgument Pointer
    // 020 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class PvpPerformancePresenter : DataModel
    {
        public IPvpPerformanceView?                     View                                    { get; set; }
        public PvpPerformanceArgument?                  Argument                                { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static PvpPerformancePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformancePresenter() { Pointer= p0 };

            value.View                                      = GetObject<IPvpPerformanceView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpPerformanceView.FromPointer); // 02466672A5F0 0x10 View                        ( 0001866089E0 ModelClassType IPvpPerformanceView IPvpPerformanceView IPvpPerformanceView Pointer )
            value.Argument                                  = GetObject<PvpPerformanceArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpPerformanceArgument.FromPointer); // 02466672A610 0x18 Argument                    ( 0001865EC130 ModelClassType PvpPerformanceArgument PvpPerformanceArgument PvpPerformanceArgument Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466672A630 0x20 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
