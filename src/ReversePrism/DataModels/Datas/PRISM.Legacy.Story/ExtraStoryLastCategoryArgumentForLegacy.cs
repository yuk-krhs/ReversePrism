using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubCategoryId                            ModelPrimitiveType int int int Int32
    // 018 ScrollPositionHolder                     ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer
    // 020 AdvTransitionerModel                     ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class ExtraStoryLastCategoryArgumentForLegacy : DataModel
    {
        public int                                      SubCategoryId                           { get; set; }
        public StoryViewScrollPositionHolder?           ScrollPositionHolder                    { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static ExtraStoryLastCategoryArgumentForLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryArgumentForLegacy() { Pointer= p0 };

            value.SubCategoryId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 SubCategoryId               ( ModelPrimitiveType int int int Int32 )
            value.ScrollPositionHolder                      = GetObject<StoryViewScrollPositionHolder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryViewScrollPositionHolder.FromPointer); // 0x18 ScrollPositionHolder        ( ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0x20 AdvTransitionerModel        ( ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
