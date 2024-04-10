using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186685BE0 ModelClassType ITwestaTopScreenView ITwestaTopScreenView ITwestaTopScreenView Pointer
    // 018 ScrollerPresenter                        0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer
    // 020 Parameter                                0001866CD840 ModelClassType TwestaTopParameter TwestaTopParameter TwestaTopParameter Pointer
    // 028 Connector                                0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.View                                      = GetObject<ITwestaTopScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaTopScreenView.FromPointer); // 024666961910 0x10 View                        ( 000186685BE0 ModelClassType ITwestaTopScreenView ITwestaTopScreenView ITwestaTopScreenView Pointer )
            value.ScrollerPresenter                         = GetObject<TwestaScrollerPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaScrollerPresenter.FromPointer); // 024666961930 0x18 ScrollerPresenter           ( 0001866CCC30 ModelClassType TwestaScrollerPresenter TwestaScrollerPresenter TwestaScrollerPresenter Pointer )
            value.Parameter                                 = GetObject<TwestaTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaTopParameter.FromPointer); // 024666961950 0x20 Parameter                   ( 0001866CD840 ModelClassType TwestaTopParameter TwestaTopParameter TwestaTopParameter Pointer )
            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 024666961970 0x28 Connector                   ( 0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666961990 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246669619B0 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
