using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SelectionTicketEmptyTextKeyId            int IL2CPP_TYPE_I4
    // 000 CostumeTicketEmptyTextKeyId              int IL2CPP_TYPE_I4
    // 010 sequencer                                IClosableSequencer`2<Unit, IExchangeTopOverlayView> IL2CPP_TYPE_GENERICINST
    // 018 View                                     ModelClassType IExchangeTopOverlayView IExchangeTopOverlayView IExchangeTopOverlayView Pointer
    // 020 ViewModel                                ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 030 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ExchangeOverlaySequencer : DataModel
    {
        public IExchangeTopOverlayView?                 View                                    { get; set; }
        public ExchangeTopViewModel?                    ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ExchangeOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeOverlaySequencer() { Pointer= p0 };

            value.View                                      = GetObject<IExchangeTopOverlayView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExchangeTopOverlayView.FromPointer); // 0x18 View                        ( ModelClassType IExchangeTopOverlayView IExchangeTopOverlayView IExchangeTopOverlayView Pointer )
            value.ViewModel                                 = GetObject<ExchangeTopViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeTopViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
