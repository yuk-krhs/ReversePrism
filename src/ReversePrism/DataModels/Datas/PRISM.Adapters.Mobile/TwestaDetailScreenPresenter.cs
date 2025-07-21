using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITwestaDetailScreenView ITwestaDetailScreenView ITwestaDetailScreenView Pointer
    // 018 Parameter                                ModelClassType TwestaDetailParameter TwestaDetailParameter TwestaDetailParameter Pointer
    // 020 ScrollerPresenter                        ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.View                                      = GetObject<ITwestaDetailScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaDetailScreenView.FromPointer); // 0x10 View                        ( ModelClassType ITwestaDetailScreenView ITwestaDetailScreenView ITwestaDetailScreenView Pointer )
            value.Parameter                                 = GetObject<TwestaDetailParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaDetailParameter.FromPointer); // 0x18 Parameter                   ( ModelClassType TwestaDetailParameter TwestaDetailParameter TwestaDetailParameter Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 0x20 ScrollerPresenter           ( ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
