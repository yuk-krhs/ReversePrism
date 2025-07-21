using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopExtraContentView IStoryTopExtraContentView IStoryTopExtraContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopExtraContentPresenter : DataModel
    {
        public IStoryTopExtraContentView?               View                                    { get; set; }
        public StoryTopExtraContentArgument?            Argument                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopExtraContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopExtraContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopExtraContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopExtraContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopExtraContentView IStoryTopExtraContentView IStoryTopExtraContentView Pointer )
            value.Argument                                  = GetObject<StoryTopExtraContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopExtraContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
