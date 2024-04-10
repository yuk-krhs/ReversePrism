using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186684D10 ModelClassType ITwestaFavoriteScreenView ITwestaFavoriteScreenView ITwestaFavoriteScreenView Pointer
    // 018 Parameter                                0001866CA3B0 ModelClassType TwestaFavoriteParameter TwestaFavoriteParameter TwestaFavoriteParameter Pointer
    // 020 ScrollerPresenter                        0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class TwestaFavoriteScreenPresenter : DataModel
    {
        public ITwestaFavoriteScreenView?               View                                    { get; set; }
        public TwestaFavoriteParameter?                 Parameter                               { get; set; }
        public TwestaScrollerPresenter?                 ScrollerPresenter                       { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static TwestaFavoriteScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteScreenPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITwestaFavoriteScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaFavoriteScreenView.FromPointer); // 02466694BA48 0x10 View                        ( 000186684D10 ModelClassType ITwestaFavoriteScreenView ITwestaFavoriteScreenView ITwestaFavoriteScreenView Pointer )
            value.Parameter                                 = GetObject<TwestaFavoriteParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaFavoriteParameter.FromPointer); // 02466694BA68 0x18 Parameter                   ( 0001866CA3B0 ModelClassType TwestaFavoriteParameter TwestaFavoriteParameter TwestaFavoriteParameter Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 02466694BA88 0x20 ScrollerPresenter           ( 0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466694BAA8 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466694BAC8 0x30 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
