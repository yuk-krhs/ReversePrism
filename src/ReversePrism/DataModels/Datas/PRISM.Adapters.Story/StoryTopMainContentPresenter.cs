using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopMainContentView IStoryTopMainContentView IStoryTopMainContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopMainContentPresenter : DataModel
    {
        public IStoryTopMainContentView?                View                                    { get; set; }
        public StoryTopMainContentArgument?             Argument                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopMainContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopMainContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopMainContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopMainContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopMainContentView IStoryTopMainContentView IStoryTopMainContentView Pointer )
            value.Argument                                  = GetObject<StoryTopMainContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopMainContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
