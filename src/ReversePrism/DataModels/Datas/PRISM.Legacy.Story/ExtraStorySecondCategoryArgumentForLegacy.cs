using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ScrollPositionHolder                     0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer
    public partial class ExtraStorySecondCategoryArgumentForLegacy
    {
        public int                                      CategoryId                              { get; set; }
        public StoryViewScrollPositionHolder?           ScrollPositionHolder                    { get; set; }

        public static ExtraStorySecondCategoryArgumentForLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryArgumentForLegacy();

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0270D5E3F4F8 0x10 CategoryId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScrollPositionHolder                      = GetObject<StoryViewScrollPositionHolder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryViewScrollPositionHolder.FromPointer); // 0270D5E3F518 0x18 ScrollPositionHolder        ( 0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer )

            return value;
        }
    }
}
