using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865B9F00 ModelClassType IMobileTopScreenView IMobileTopScreenView IMobileTopScreenView Pointer
    // 018 Model                                    000186638BE0 ModelClassType MobileTopScreenModel MobileTopScreenModel MobileTopScreenModel Pointer
    // 020 Parameter                                0001866384E0 ModelClassType MobileTopParameter MobileTopParameter MobileTopParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class MobileTopScreenPresenter
    {
        public IMobileTopScreenView?                    View                                    { get; set; }
        public MobileTopScreenModel?                    Model                                   { get; set; }
        public MobileTopParameter?                      Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static MobileTopScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTopScreenPresenter();

            value.View                                      = GetObject<IMobileTopScreenView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileTopScreenView.FromPointer); // 0270D689E718 0x10 View                        ( 0001865B9F00 ModelClassType IMobileTopScreenView IMobileTopScreenView IMobileTopScreenView Pointer )
            value.Model                                     = GetObject<MobileTopScreenModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MobileTopScreenModel.FromPointer); // 0270D689E738 0x18 Model                       ( 000186638BE0 ModelClassType MobileTopScreenModel MobileTopScreenModel MobileTopScreenModel Pointer )
            value.Parameter                                 = GetObject<MobileTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileTopParameter.FromPointer); // 0270D689E758 0x20 Parameter                   ( 0001866384E0 ModelClassType MobileTopParameter MobileTopParameter MobileTopParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0270D689E778 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D689E798 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D689E7B8 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
