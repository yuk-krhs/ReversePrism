using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018665E180 ModelClassType IStoryToAdvTransitionerView IStoryToAdvTransitionerView IStoryToAdvTransitionerView Pointer
    // 018 Model                                    0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class StoryToAdvTransitionerPresenter : DataModel
    {
        public IStoryToAdvTransitionerView?             View                                    { get; set; }
        public StoryToAdvTransitionerModel?             Model                                   { get; set; }

        public static StoryToAdvTransitionerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryToAdvTransitionerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IStoryToAdvTransitionerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryToAdvTransitionerView.FromPointer); // 0246667F8750 0x10 View                        ( 00018665E180 ModelClassType IStoryToAdvTransitionerView IStoryToAdvTransitionerView IStoryToAdvTransitionerView Pointer )
            value.Model                                     = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0246667F8770 0x18 Model                       ( 0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
