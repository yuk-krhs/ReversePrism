using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopFavoriteContentView IStoryTopFavoriteContentView IStoryTopFavoriteContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer
    // 020 CellDataContainer                        ModelClassType StoryTopFavoriteCellDataContainer StoryTopFavoriteCellDataContainer StoryTopFavoriteCellDataContainer Pointer
    // 028 AdvTransitionerPresenter                 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopFavoriteContentPresenter : DataModel
    {
        public IStoryTopFavoriteContentView?            View                                    { get; set; }
        public StoryTopFavoriteContentArgument?         Argument                                { get; set; }
        public StoryTopFavoriteCellDataContainer?       CellDataContainer                       { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopFavoriteContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopFavoriteContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopFavoriteContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopFavoriteContentView IStoryTopFavoriteContentView IStoryTopFavoriteContentView Pointer )
            value.Argument                                  = GetObject<StoryTopFavoriteContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopFavoriteContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer )
            value.CellDataContainer                         = GetObject<StoryTopFavoriteCellDataContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopFavoriteCellDataContainer.FromPointer); // 0x20 CellDataContainer           ( ModelClassType StoryTopFavoriteCellDataContainer StoryTopFavoriteCellDataContainer StoryTopFavoriteCellDataContainer Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x28 AdvTransitionerPresenter    ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
