using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001866851F0 ModelClassType ITwestaProfileScreenView ITwestaProfileScreenView ITwestaProfileScreenView Pointer
    // 018 ScrollerPresenter                        0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 020 Parameter                                0001866CB910 ModelClassType TwestaProfileParameter TwestaProfileParameter TwestaProfileParameter Pointer
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.View                                      = GetObject<ITwestaProfileScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaProfileScreenView.FromPointer); // 02466694E520 0x10 View                        ( 0001866851F0 ModelClassType ITwestaProfileScreenView ITwestaProfileScreenView ITwestaProfileScreenView Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 02466694E540 0x18 ScrollerPresenter           ( 0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Parameter                                 = GetObject<TwestaProfileParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaProfileParameter.FromPointer); // 02466694E560 0x20 Parameter                   ( 0001866CB910 ModelClassType TwestaProfileParameter TwestaProfileParameter TwestaProfileParameter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466694E580 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466694E5A0 0x30 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
