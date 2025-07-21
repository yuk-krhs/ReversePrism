using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ChainTopScreenModel ChainTopScreenModel ChainTopScreenModel Pointer
    // 018 View                                     ModelClassType IChainTopScreenView IChainTopScreenView IChainTopScreenView Pointer
    // 020 Parameter                                ModelClassType ChainTopParameter ChainTopParameter ChainTopParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChainTopScreenPresenter : DataModel
    {
        public ChainTopScreenModel?                     Model                                   { get; set; }
        public IChainTopScreenView?                     View                                    { get; set; }
        public ChainTopParameter?                       Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ChainTopScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTopScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ChainTopScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTopScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType ChainTopScreenModel ChainTopScreenModel ChainTopScreenModel Pointer )
            value.View                                      = GetObject<IChainTopScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainTopScreenView.FromPointer); // 0x18 View                        ( ModelClassType IChainTopScreenView IChainTopScreenView IChainTopScreenView Pointer )
            value.Parameter                                 = GetObject<ChainTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTopParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType ChainTopParameter ChainTopParameter ChainTopParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
