using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 000186768650 ModelClassType EventStoryFirstCategoryCellList EventStoryFirstCategoryCellList EventStoryFirstCategoryCellList Pointer
    // 028 UnreadStoryToggle                        000186735EA0 ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer
    public partial class StoryTopEventContentView
    {
        public EventStoryFirstCategoryCellList?         CellList                                { get; set; }
        public UnreadStoryToggle?                       UnreadStoryToggle                       { get; set; }

        public static StoryTopEventContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopEventContentView();

            value.CellList                                  = GetObject<EventStoryFirstCategoryCellList>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventStoryFirstCategoryCellList.FromPointer); // 0270DB96F520 0x20 CellList                    ( 000186768650 ModelClassType EventStoryFirstCategoryCellList EventStoryFirstCategoryCellList EventStoryFirstCategoryCellList Pointer )
            value.UnreadStoryToggle                         = GetObject<UnreadStoryToggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnreadStoryToggle.FromPointer); // 0270DB96F540 0x28 UnreadStoryToggle           ( 000186735EA0 ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer )

            return value;
        }
    }
}
