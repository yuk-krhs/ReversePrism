using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186684830 ModelClassType ITwestaDetailScreenView ITwestaDetailScreenView ITwestaDetailScreenView Pointer
    // 018 Parameter                                0001866C9030 ModelClassType TwestaDetailParameter TwestaDetailParameter TwestaDetailParameter Pointer
    // 020 ScrollerPresenter                        0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class TwestaDetailScreenPresenter : DataModel
    {
        public ITwestaDetailScreenView?                 View                                    { get; set; }
        public TwestaDetailParameter?                   Parameter                               { get; set; }
        public TwestaScrollerPresenter?                 ScrollerPresenter                       { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static TwestaDetailScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaDetailScreenPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITwestaDetailScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaDetailScreenView.FromPointer); // 024666948838 0x10 View                        ( 000186684830 ModelClassType ITwestaDetailScreenView ITwestaDetailScreenView ITwestaDetailScreenView Pointer )
            value.Parameter                                 = GetObject<TwestaDetailParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaDetailParameter.FromPointer); // 024666948858 0x18 Parameter                   ( 0001866C9030 ModelClassType TwestaDetailParameter TwestaDetailParameter TwestaDetailParameter Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 024666948878 0x20 ScrollerPresenter           ( 0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666948898 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246669488B8 0x30 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
