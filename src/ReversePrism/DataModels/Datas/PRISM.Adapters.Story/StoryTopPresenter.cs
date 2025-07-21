using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopView IStoryTopView IStoryTopView Pointer
    // 018 Argument                                 ModelClassType StoryTopArgument StoryTopArgument StoryTopArgument Pointer
    // 020 Model                                    ModelClassType StoryTopModel StoryTopModel StoryTopModel Pointer
    // 028 FavoritePresenter                        ModelClassType StoryTopFavoriteContentPresenter StoryTopFavoriteContentPresenter StoryTopFavoriteContentPresenter Pointer
    // 030 SearchPresenter                          ModelClassType StoryTopSearchContentPresenter StoryTopSearchContentPresenter StoryTopSearchContentPresenter Pointer
    // 038 AdvTransitionerPresenterForFavorite      ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 040 AdvTransitionerPresenterForSearch        ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 048 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopPresenter : DataModel
    {
        public IStoryTopView?                           View                                    { get; set; }
        public StoryTopArgument?                        Argument                                { get; set; }
        public StoryTopModel?                           Model                                   { get; set; }
        public StoryTopFavoriteContentPresenter?        FavoritePresenter                       { get; set; }
        public StoryTopSearchContentPresenter?          SearchPresenter                         { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenterForFavorite     { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenterForSearch       { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopView IStoryTopView IStoryTopView Pointer )
            value.Argument                                  = GetObject<StoryTopArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopArgument StoryTopArgument StoryTopArgument Pointer )
            value.Model                                     = GetObject<StoryTopModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopModel.FromPointer); // 0x20 Model                       ( ModelClassType StoryTopModel StoryTopModel StoryTopModel Pointer )
            value.FavoritePresenter                         = GetObject<StoryTopFavoriteContentPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopFavoriteContentPresenter.FromPointer); // 0x28 FavoritePresenter           ( ModelClassType StoryTopFavoriteContentPresenter StoryTopFavoriteContentPresenter StoryTopFavoriteContentPresenter Pointer )
            value.SearchPresenter                           = GetObject<StoryTopSearchContentPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopSearchContentPresenter.FromPointer); // 0x30 SearchPresenter             ( ModelClassType StoryTopSearchContentPresenter StoryTopSearchContentPresenter StoryTopSearchContentPresenter Pointer )
            value.AdvTransitionerPresenterForFavorite       = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x38 AdvTransitionerPresenterForFavorite ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.AdvTransitionerPresenterForSearch         = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x40 AdvTransitionerPresenterForSearch ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x48 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x50 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
