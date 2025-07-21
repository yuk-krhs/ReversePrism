using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType CallPlaybackScreenModel CallPlaybackScreenModel CallPlaybackScreenModel Pointer
    // 018 View                                     ModelClassType ICallPlaybackScreenView ICallPlaybackScreenView ICallPlaybackScreenView Pointer
    // 020 Parameter                                ModelClassType CallPlaybackParameter CallPlaybackParameter CallPlaybackParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 CurrentCallPlayBack                      ModelClassType PhoneCall PhoneCall PhoneCall Pointer
    public partial class CallPlaybackScreenPresenter : DataModel
    {
        public CallPlaybackScreenModel?                 Model                                   { get; set; }
        public ICallPlaybackScreenView?                 View                                    { get; set; }
        public CallPlaybackParameter?                   Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public PhoneCall?                               CurrentCallPlayBack                     { get; set; }

        public static CallPlaybackScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<CallPlaybackScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallPlaybackScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType CallPlaybackScreenModel CallPlaybackScreenModel CallPlaybackScreenModel Pointer )
            value.View                                      = GetObject<ICallPlaybackScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICallPlaybackScreenView.FromPointer); // 0x18 View                        ( ModelClassType ICallPlaybackScreenView ICallPlaybackScreenView ICallPlaybackScreenView Pointer )
            value.Parameter                                 = GetObject<CallPlaybackParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallPlaybackParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType CallPlaybackParameter CallPlaybackParameter CallPlaybackParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentCallPlayBack                       = GetObject<PhoneCall>(new IntPtr(p + 0x040), ReversePrism.DataModels.PhoneCall.FromPointer); // 0x40 CurrentCallPlayBack         ( ModelClassType PhoneCall PhoneCall PhoneCall Pointer )

            return value;
        }
    }
}
