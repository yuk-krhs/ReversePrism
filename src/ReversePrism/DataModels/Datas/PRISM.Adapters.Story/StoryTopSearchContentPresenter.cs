using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001866603F0 ModelClassType IStoryTopSearchContentView IStoryTopSearchContentView IStoryTopSearchContentView Pointer
    // 018 Argument                                 0001865AED10 ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer
    // 020 CellDataContainer                        0001865ADBB0 ModelClassType StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer Pointer
    // 028 AdvTransitionerPresenter                 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopSearchContentPresenter : DataModel
    {
        public IStoryTopSearchContentView?              View                                    { get; set; }
        public StoryTopStorySearchContentArgument?      Argument                                { get; set; }
        public StoryTopSearchCellDataContainer?         CellDataContainer                       { get; set; }
        public StoryToAdvTransitionerPresenter?         AdvTransitionerPresenter                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopSearchContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopSearchContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopSearchContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopSearchContentView.FromPointer); // 02466685E448 0x10 View                        ( 0001866603F0 ModelClassType IStoryTopSearchContentView IStoryTopSearchContentView IStoryTopSearchContentView Pointer )
            value.Argument                                  = GetObject<StoryTopStorySearchContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopStorySearchContentArgument.FromPointer); // 02466685E468 0x18 Argument                    ( 0001865AED10 ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer )
            value.CellDataContainer                         = GetObject<StoryTopSearchCellDataContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopSearchCellDataContainer.FromPointer); // 02466685E488 0x20 CellDataContainer           ( 0001865ADBB0 ModelClassType StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer StoryTopSearchCellDataContainer Pointer )
            value.AdvTransitionerPresenter                  = GetObject<StoryToAdvTransitionerPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryToAdvTransitionerPresenter.FromPointer); // 02466685E4A8 0x28 AdvTransitionerPresenter    ( 0001865A5E70 ModelClassType StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter StoryToAdvTransitionerPresenter Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466685E4C8 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
