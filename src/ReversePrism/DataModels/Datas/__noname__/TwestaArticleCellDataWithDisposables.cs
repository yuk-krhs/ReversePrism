using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 000186683330 ModelClassType ITwestaArticleCellData ITwestaArticleCellData ITwestaArticleCellData Pointer
    // 018 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class TwestaArticleCellDataWithDisposables
    {
        public ITwestaArticleCellData?                  CellData                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static TwestaArticleCellDataWithDisposables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCellDataWithDisposables();

            value.CellData                                  = GetObject<ITwestaArticleCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaArticleCellData.FromPointer); // 0270DB17E518 0x10 CellData                    ( 000186683330 ModelClassType ITwestaArticleCellData ITwestaArticleCellData ITwestaArticleCellData Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DB17E538 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB17E558 0x20 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
