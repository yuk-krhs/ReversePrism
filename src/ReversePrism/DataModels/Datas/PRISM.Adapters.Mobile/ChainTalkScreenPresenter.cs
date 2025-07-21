using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ChainTalkScreenModel ChainTalkScreenModel ChainTalkScreenModel Pointer
    // 018 View                                     ModelClassType IChainTalkScreenView IChainTalkScreenView IChainTalkScreenView Pointer
    // 020 Parameter                                ModelClassType ChainTalkParameter ChainTalkParameter ChainTalkParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 ReadScroller                             ModelClassType ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter Pointer
    // 038 UnreadScroller                           ModelClassType ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter Pointer
    // 040 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChainTalkScreenPresenter : DataModel
    {
        public ChainTalkScreenModel?                    Model                                   { get; set; }
        public IChainTalkScreenView?                    View                                    { get; set; }
        public ChainTalkParameter?                      Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public ChainTalkReadScrollerPresenter?          ReadScroller                            { get; set; }
        public ChainUnreadTalkScrollerPresenter?        UnreadScroller                          { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainTalkScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ChainTalkScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType ChainTalkScreenModel ChainTalkScreenModel ChainTalkScreenModel Pointer )
            value.View                                      = GetObject<IChainTalkScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainTalkScreenView.FromPointer); // 0x18 View                        ( ModelClassType IChainTalkScreenView IChainTalkScreenView IChainTalkScreenView Pointer )
            value.Parameter                                 = GetObject<ChainTalkParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType ChainTalkParameter ChainTalkParameter ChainTalkParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.ReadScroller                              = GetObject<ChainTalkReadScrollerPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkReadScrollerPresenter.FromPointer); // 0x30 ReadScroller                ( ModelClassType ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter ChainTalkReadScrollerPresenter Pointer )
            value.UnreadScroller                            = GetObject<ChainUnreadTalkScrollerPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainUnreadTalkScrollerPresenter.FromPointer); // 0x38 UnreadScroller              ( ModelClassType ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter ChainUnreadTalkScrollerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x48 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
