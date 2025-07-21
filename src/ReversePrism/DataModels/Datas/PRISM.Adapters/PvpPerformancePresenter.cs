using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IPvpPerformanceView IPvpPerformanceView IPvpPerformanceView Pointer
    // 018 Argument                                 ModelClassType PvpPerformanceArgument PvpPerformanceArgument PvpPerformanceArgument Pointer
    // 020 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class PvpPerformancePresenter : DataModel
    {
        public IPvpPerformanceView?                     View                                    { get; set; }
        public PvpPerformanceArgument?                  Argument                                { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static PvpPerformancePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformancePresenter() { Pointer= p0 };

            value.View                                      = GetObject<IPvpPerformanceView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpPerformanceView.FromPointer); // 0x10 View                        ( ModelClassType IPvpPerformanceView IPvpPerformanceView IPvpPerformanceView Pointer )
            value.Argument                                  = GetObject<PvpPerformanceArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpPerformanceArgument.FromPointer); // 0x18 Argument                    ( ModelClassType PvpPerformanceArgument PvpPerformanceArgument PvpPerformanceArgument Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
