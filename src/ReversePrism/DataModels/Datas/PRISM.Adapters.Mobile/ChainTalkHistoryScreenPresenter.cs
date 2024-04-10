using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186561A70 ModelClassType ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel Pointer
    // 018 View                                     00018671E230 ModelClassType IChainTalkHistoryScreenView IChainTalkHistoryScreenView IChainTalkHistoryScreenView Pointer
    // 020 Parameter                                0001865612B0 ModelClassType ChainTalkHistoryParameter ChainTalkHistoryParameter ChainTalkHistoryParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChainTalkHistoryScreenPresenter : DataModel
    {
        public ChainTalkHistoryScreenModel?             Model                                   { get; set; }
        public IChainTalkHistoryScreenView?             View                                    { get; set; }
        public ChainTalkHistoryParameter?               Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ChainTalkHistoryScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkHistoryScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ChainTalkHistoryScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkHistoryScreenModel.FromPointer); // 0246668EA158 0x10 Model                       ( 000186561A70 ModelClassType ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel Pointer )
            value.View                                      = GetObject<IChainTalkHistoryScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainTalkHistoryScreenView.FromPointer); // 0246668EA178 0x18 View                        ( 00018671E230 ModelClassType IChainTalkHistoryScreenView IChainTalkHistoryScreenView IChainTalkHistoryScreenView Pointer )
            value.Parameter                                 = GetObject<ChainTalkHistoryParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkHistoryParameter.FromPointer); // 0246668EA198 0x20 Parameter                   ( 0001865612B0 ModelClassType ChainTalkHistoryParameter ChainTalkHistoryParameter ChainTalkHistoryParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0246668EA1B8 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246668EA1D8 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668EA1F8 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
