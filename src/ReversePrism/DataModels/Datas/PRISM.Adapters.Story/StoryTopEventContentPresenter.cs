using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IStoryTopEventContentView IStoryTopEventContentView IStoryTopEventContentView Pointer
    // 018 Argument                                 ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class StoryTopEventContentPresenter : DataModel
    {
        public IStoryTopEventContentView?               View                                    { get; set; }
        public StoryTopEventContentArgument?            Argument                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StoryTopEventContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopEventContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryTopEventContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryTopEventContentView.FromPointer); // 0x10 View                        ( ModelClassType IStoryTopEventContentView IStoryTopEventContentView IStoryTopEventContentView Pointer )
            value.Argument                                  = GetObject<StoryTopEventContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopEventContentArgument.FromPointer); // 0x18 Argument                    ( ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
