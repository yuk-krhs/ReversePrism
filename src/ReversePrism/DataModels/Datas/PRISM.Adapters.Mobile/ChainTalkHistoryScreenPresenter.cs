using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel Pointer
    // 018 View                                     ModelClassType IChainTalkHistoryScreenView IChainTalkHistoryScreenView IChainTalkHistoryScreenView Pointer
    // 020 Parameter                                ModelClassType ChainTalkHistoryParameter ChainTalkHistoryParameter ChainTalkHistoryParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.Model                                     = GetObject<ChainTalkHistoryScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkHistoryScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel ChainTalkHistoryScreenModel Pointer )
            value.View                                      = GetObject<IChainTalkHistoryScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainTalkHistoryScreenView.FromPointer); // 0x18 View                        ( ModelClassType IChainTalkHistoryScreenView IChainTalkHistoryScreenView IChainTalkHistoryScreenView Pointer )
            value.Parameter                                 = GetObject<ChainTalkHistoryParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkHistoryParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType ChainTalkHistoryParameter ChainTalkHistoryParameter ChainTalkHistoryParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
