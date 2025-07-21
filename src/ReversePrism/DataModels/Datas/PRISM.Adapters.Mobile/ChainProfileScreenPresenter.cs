using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ChainProfileScreenModel ChainProfileScreenModel ChainProfileScreenModel Pointer
    // 018 View                                     ModelClassType IChainProfileScreenView IChainProfileScreenView IChainProfileScreenView Pointer
    // 020 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 028 Parameter                                ModelClassType ChainProfileParameter ChainProfileParameter ChainProfileParameter Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChainProfileScreenPresenter : DataModel
    {
        public ChainProfileScreenModel?                 Model                                   { get; set; }
        public IChainProfileScreenView?                 View                                    { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public ChainProfileParameter?                   Parameter                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ChainProfileScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainProfileScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ChainProfileScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainProfileScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType ChainProfileScreenModel ChainProfileScreenModel ChainProfileScreenModel Pointer )
            value.View                                      = GetObject<IChainProfileScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainProfileScreenView.FromPointer); // 0x18 View                        ( ModelClassType IChainProfileScreenView IChainProfileScreenView IChainProfileScreenView Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x20 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Parameter                                 = GetObject<ChainProfileParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainProfileParameter.FromPointer); // 0x28 Parameter                   ( ModelClassType ChainProfileParameter ChainProfileParameter ChainProfileParameter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
