using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopSearchContentView IStoryTopSearchContentView IStoryTopSearchContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopSearchContentArgument StoryTopSearchContentArgument StoryTopSearchContentArgument Pointer
    // 020 CellDataContainer                        ModelClassType StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer Pointer
    // 028 AdvTransitionerPresenter                 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopSearchContentPresenter : DataModel
    {
        public IStoryTopSearchContentView?              View                                    { get; set; }
        public StoryTopSearchContentArgument?           Argument                                { get; set; }
        public StoryTopSearchCellDataContainer?         CellDataContainer                       { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopSearchContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopSearchContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopSearchContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopSearchContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopSearchContentView IStoryTopSearchContentView IStoryTopSearchContentView Pointer )
            value.Argument                                  = GetObject<StoryTopSearchContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopSearchContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopSearchContentArgument StoryTopSearchContentArgument StoryTopSearchContentArgument Pointer )
            value.CellDataContainer                         = GetObject<StoryTopSearchCellDataContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopSearchCellDataContainer.FromPointer); // 0x20 CellDataContainer           ( ModelClassType StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 0x28 AdvTransitionerPresenter    ( ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
