using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopIdolContentView IStoryTopIdolContentView IStoryTopIdolContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopIdolContentPresenter : DataModel
    {
        public IStoryTopIdolContentView?                View                                    { get; set; }
        public StoryTopIdolContentArgument?             Argument                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopIdolContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopIdolContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopIdolContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopIdolContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopIdolContentView IStoryTopIdolContentView IStoryTopIdolContentView Pointer )
            value.Argument                                  = GetObject<StoryTopIdolContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopIdolContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
