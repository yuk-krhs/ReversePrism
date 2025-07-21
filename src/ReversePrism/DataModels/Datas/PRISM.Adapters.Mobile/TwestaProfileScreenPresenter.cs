using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITwestaProfileScreenView ITwestaProfileScreenView ITwestaProfileScreenView Pointer
    // 018 ScrollerPresenter                        ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 020 Parameter                                ModelClassType TwestaProfileParameter TwestaProfileParameter TwestaProfileParameter Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class TwestaProfileScreenPresenter : DataModel
    {
        public ITwestaProfileScreenView?                View                                    { get; set; }
        public TwestaScrollerPresenter?                 ScrollerPresenter                       { get; set; }
        public TwestaProfileParameter?                  Parameter                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static TwestaProfileScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaProfileScreenPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITwestaProfileScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaProfileScreenView.FromPointer); // 0x10 View                        ( ModelClassType ITwestaProfileScreenView ITwestaProfileScreenView ITwestaProfileScreenView Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 0x18 ScrollerPresenter           ( ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Parameter                                 = GetObject<TwestaProfileParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaProfileParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType TwestaProfileParameter TwestaProfileParameter TwestaProfileParameter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
