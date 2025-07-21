using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 ModelClassType IChainTalkCellData IChainTalkCellData IChainTalkCellData Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ChainTalkCellDataWithDisposables : DataModel
    {
        public IChainTalkCellData?                      CellData                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static ChainTalkCellDataWithDisposables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellDataWithDisposables() { Pointer= p0 };

            value.CellData                                  = GetObject<IChainTalkCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChainTalkCellData.FromPointer); // 0x10 CellData                    ( ModelClassType IChainTalkCellData IChainTalkCellData IChainTalkCellData Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
