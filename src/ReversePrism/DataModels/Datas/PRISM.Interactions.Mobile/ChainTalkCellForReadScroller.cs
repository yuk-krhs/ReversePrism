using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CellBase                                 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer
    // 068 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ChainTalkCellForReadScroller : DataModel
    {
        public ChainTalkCellBase?                       CellBase                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static ChainTalkCellForReadScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellForReadScroller() { Pointer= p0 };

            value.CellBase                                  = GetObject<ChainTalkCellBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChainTalkCellBase.FromPointer); // 0x60 CellBase                    ( ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x68 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
