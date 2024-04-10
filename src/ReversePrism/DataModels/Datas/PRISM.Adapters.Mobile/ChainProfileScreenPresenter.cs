using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186559AE0 ModelClassType ChainProfileScreenModel ChainProfileScreenModel ChainProfileScreenModel Pointer
    // 018 View                                     00018671C750 ModelClassType IChainProfileScreenView IChainProfileScreenView IChainProfileScreenView Pointer
    // 020 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 028 Parameter                                000186559390 ModelClassType ChainProfileParameter ChainProfileParameter ChainProfileParameter Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.Model                                     = GetObject<ChainProfileScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainProfileScreenModel.FromPointer); // 0246668C60B0 0x10 Model                       ( 000186559AE0 ModelClassType ChainProfileScreenModel ChainProfileScreenModel ChainProfileScreenModel Pointer )
            value.View                                      = GetObject<IChainProfileScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainProfileScreenView.FromPointer); // 0246668C60D0 0x18 View                        ( 00018671C750 ModelClassType IChainProfileScreenView IChainProfileScreenView IChainProfileScreenView Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0246668C60F0 0x20 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Parameter                                 = GetObject<ChainProfileParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainProfileParameter.FromPointer); // 0246668C6110 0x28 Parameter                   ( 000186559390 ModelClassType ChainProfileParameter ChainProfileParameter ChainProfileParameter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246668C6130 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668C6150 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
