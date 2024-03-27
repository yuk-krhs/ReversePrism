using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186685710 ModelClassType ITwestaScrollerView ITwestaScrollerView ITwestaScrollerView Pointer
    // 018 Fetcher                                  000186683CC0 ModelClassType ITwestaArticleFetcher ITwestaArticleFetcher ITwestaArticleFetcher Pointer
    // 020 TemporaryCacheUpdater                    0001866C7EE0 ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer
    // 028 Connector                                0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 030 cellDataCreator                          Func`2<ITwestaArticleStatus, ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 TokenSource                              0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 IsUpdating                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TwestaScrollerPresenter
    {
        public ITwestaScrollerView?                     View                                    { get; set; }
        public ITwestaArticleFetcher?                   Fetcher                                 { get; set; }
        public TwestaArticleTemporaryCacheUpdater?      TemporaryCacheUpdater                   { get; set; }
        public IMobileScreenConnector?                  Connector                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public bool                                     IsUpdating                              { get; set; }

        public static TwestaScrollerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaScrollerPresenter();

            value.View                                      = GetObject<ITwestaScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaScrollerView.FromPointer); // 0270D68D9178 0x10 View                        ( 000186685710 ModelClassType ITwestaScrollerView ITwestaScrollerView ITwestaScrollerView Pointer )
            value.Fetcher                                   = GetObject<ITwestaArticleFetcher>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITwestaArticleFetcher.FromPointer); // 0270D68D9198 0x18 Fetcher                     ( 000186683CC0 ModelClassType ITwestaArticleFetcher ITwestaArticleFetcher ITwestaArticleFetcher Pointer )
            value.TemporaryCacheUpdater                     = GetObject<TwestaArticleTemporaryCacheUpdater>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaArticleTemporaryCacheUpdater.FromPointer); // 0270D68D91B8 0x20 TemporaryCacheUpdater       ( 0001866C7EE0 ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer )
            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 0270D68D91D8 0x28 Connector                   ( 0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D68D9218 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D68D9238 0x40 TokenSource                 ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsUpdating                                = GetBool(new IntPtr(p + 0x048)); // 0270D68D9258 0x48 IsUpdating                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
