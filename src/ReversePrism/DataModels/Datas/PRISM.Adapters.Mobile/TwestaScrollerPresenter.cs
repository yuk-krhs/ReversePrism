using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITwestaScrollerView ITwestaScrollerView ITwestaScrollerView Pointer
    // 018 Fetcher                                  ModelClassType ITwestaArticleFetcher ITwestaArticleFetcher ITwestaArticleFetcher Pointer
    // 020 TemporaryCacheUpdater                    ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer
    // 028 Connector                                ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 030 cellDataCreator                          Func`2<ITwestaArticleStatus, ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 IsUpdating                               ModelPrimitiveType bool bool bool Bool
    public partial class TwestaScrollerPresenter : DataModel
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
            var value   = new TwestaScrollerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITwestaScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaScrollerView.FromPointer); // 0x10 View                        ( ModelClassType ITwestaScrollerView ITwestaScrollerView ITwestaScrollerView Pointer )
            value.Fetcher                                   = GetObject<ITwestaArticleFetcher>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITwestaArticleFetcher.FromPointer); // 0x18 Fetcher                     ( ModelClassType ITwestaArticleFetcher ITwestaArticleFetcher ITwestaArticleFetcher Pointer )
            value.TemporaryCacheUpdater                     = GetObject<TwestaArticleTemporaryCacheUpdater>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaArticleTemporaryCacheUpdater.FromPointer); // 0x20 TemporaryCacheUpdater       ( ModelClassType TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater TwestaArticleTemporaryCacheUpdater Pointer )
            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 0x28 Connector                   ( ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsUpdating                                = GetBool(new IntPtr(p + 0x048)); // 0x48 IsUpdating                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
