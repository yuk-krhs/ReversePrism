using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186564F30 ModelClassType ChainTalkScreenModel ChainTalkScreenModel ChainTalkScreenModel Pointer
    // 018 View                                     00018671E710 ModelClassType IChainTalkScreenView IChainTalkScreenView IChainTalkScreenView Pointer
    // 020 Parameter                                000186563D70 ModelClassType ChainTalkParameter ChainTalkParameter ChainTalkParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 ReadScroller                             0001865642B0 ModelClassType ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter Pointer
    // 038 UnreadScroller                           00018656B0E0 ModelClassType ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter Pointer
    // 040 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChainTalkScreenPresenter
    {
        public ChainTalkScreenModel?                    Model                                   { get; set; }
        public IChainTalkScreenView?                    View                                    { get; set; }
        public ChainTalkParameter?                      Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public ChainTalkReadScrollerPresenter?          ReadScroller                            { get; set; }
        public ChainUnreadTalkScrollerPresenter?        UnreadScroller                          { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ChainTalkScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkScreenPresenter();

            value.Model                                     = GetObject<ChainTalkScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkScreenModel.FromPointer); // 0270D686AF88 0x10 Model                       ( 000186564F30 ModelClassType ChainTalkScreenModel ChainTalkScreenModel ChainTalkScreenModel Pointer )
            value.View                                      = GetObject<IChainTalkScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainTalkScreenView.FromPointer); // 0270D686AFA8 0x18 View                        ( 00018671E710 ModelClassType IChainTalkScreenView IChainTalkScreenView IChainTalkScreenView Pointer )
            value.Parameter                                 = GetObject<ChainTalkParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkParameter.FromPointer); // 0270D686AFC8 0x20 Parameter                   ( 000186563D70 ModelClassType ChainTalkParameter ChainTalkParameter ChainTalkParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0270D686AFE8 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.ReadScroller                              = GetObject<ChainTalkReadScrollerPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkReadScrollerPresenter.FromPointer); // 0270D686B008 0x30 ReadScroller                ( 0001865642B0 ModelClassType ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter Pointer )
            value.UnreadScroller                            = GetObject<ChainUnreadTalkScrollerPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainUnreadTalkScrollerPresenter.FromPointer); // 0270D686B028 0x38 UnreadScroller              ( 00018656B0E0 ModelClassType ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D686B048 0x40 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D686B068 0x48 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
