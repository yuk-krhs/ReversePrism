using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    00018652F7F0 ModelClassType CallTopScreenModel CallTopScreenModel CallTopScreenModel Pointer
    // 018 View                                     000186717E80 ModelClassType ICallTopScreenView ICallTopScreenView ICallTopScreenView Pointer
    // 020 Parameter                                00018652F0B0 ModelClassType CallTopParameter CallTopParameter CallTopParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class CallTopScreenPresenter
    {
        public CallTopScreenModel?                      Model                                   { get; set; }
        public ICallTopScreenView?                      View                                    { get; set; }
        public CallTopParameter?                        Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static CallTopScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopScreenPresenter();

            value.Model                                     = GetObject<CallTopScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallTopScreenModel.FromPointer); // 0270D68628B8 0x10 Model                       ( 00018652F7F0 ModelClassType CallTopScreenModel CallTopScreenModel CallTopScreenModel Pointer )
            value.View                                      = GetObject<ICallTopScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICallTopScreenView.FromPointer); // 0270D68628D8 0x18 View                        ( 000186717E80 ModelClassType ICallTopScreenView ICallTopScreenView ICallTopScreenView Pointer )
            value.Parameter                                 = GetObject<CallTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallTopParameter.FromPointer); // 0270D68628F8 0x20 Parameter                   ( 00018652F0B0 ModelClassType CallTopParameter CallTopParameter CallTopParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0270D6862918 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6862938 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6862958 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
