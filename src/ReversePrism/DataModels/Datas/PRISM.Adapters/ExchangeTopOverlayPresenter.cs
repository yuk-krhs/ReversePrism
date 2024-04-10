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
    // 010 View                                     00018676DD30 ModelClassType IExchangeTopOverlayView IExchangeTopOverlayView IExchangeTopOverlayView Pointer
    // 018 ViewModel                                00018651EC30 ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer
    // 020 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ExchangeTopOverlayPresenter : DataModel
    {
        public IExchangeTopOverlayView?                 View                                    { get; set; }
        public ExchangeTopViewModel?                    ViewModel                               { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ExchangeTopOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTopOverlayPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IExchangeTopOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExchangeTopOverlayView.FromPointer); // 0246663291E8 0x10 View                        ( 00018676DD30 ModelClassType IExchangeTopOverlayView IExchangeTopOverlayView IExchangeTopOverlayView Pointer )
            value.ViewModel                                 = GetObject<ExchangeTopViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeTopViewModel.FromPointer); // 024666329208 0x18 ViewModel                   ( 00018651EC30 ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666329228 0x20 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666329248 0x28 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
