using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITwestaTopScreenView ITwestaTopScreenView ITwestaTopScreenView Pointer
    // 018 ScrollerPresenter                        ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 020 Parameter                                ModelClassType TwestaTopParameter TwestaTopParameter TwestaTopParameter Pointer
    // 028 Connector                                ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class TwestaTopScreenPresenter : DataModel
    {
        public ITwestaTopScreenView?                    View                                    { get; set; }
        public TwestaScrollerPresenter?                 ScrollerPresenter                       { get; set; }
        public TwestaTopParameter?                      Parameter                               { get; set; }
        public IMobileScreenConnector?                  Connector                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static TwestaTopScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopScreenPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITwestaTopScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaTopScreenView.FromPointer); // 0x10 View                        ( ModelClassType ITwestaTopScreenView ITwestaTopScreenView ITwestaTopScreenView Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 0x18 ScrollerPresenter           ( ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Parameter                                 = GetObject<TwestaTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaTopParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType TwestaTopParameter TwestaTopParameter TwestaTopParameter Pointer )
            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 0x28 Connector                   ( ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
