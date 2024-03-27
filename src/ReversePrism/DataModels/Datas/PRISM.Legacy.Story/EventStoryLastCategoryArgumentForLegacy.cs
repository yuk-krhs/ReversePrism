using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ScrollPositionHolder                     0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer
    // 020 AdvTransitionerModel                     0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class EventStoryLastCategoryArgumentForLegacy
    {
        public int                                      EventId                                 { get; set; }
        public StoryViewScrollPositionHolder?           ScrollPositionHolder                    { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static EventStoryLastCategoryArgumentForLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryArgumentForLegacy();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D5E3ED98 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScrollPositionHolder                      = GetObject<StoryViewScrollPositionHolder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryViewScrollPositionHolder.FromPointer); // 0270D5E3EDB8 0x18 ScrollPositionHolder        ( 0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0270D5E3EDD8 0x20 AdvTransitionerModel        ( 0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
