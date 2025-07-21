using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 ModelClassType ExtraStoryFirstCategoryCellList ExtraStoryFirstCategoryCellList ExtraStoryFirstCategoryCellList Pointer
    // 028 UnreadStoryToggle                        ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer
    public partial class StoryTopExtraContentView : DataModel
    {
        public ExtraStoryFirstCategoryCellList?         CellList                                { get; set; }
        public UnreadStoryToggle?                       UnreadStoryToggle                       { get; set; }

        public static StoryTopExtraContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopExtraContentView() { Pointer= p0 };

            value.CellList                                  = GetObject<ExtraStoryFirstCategoryCellList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStoryFirstCategoryCellList.FromPointer); // 0x20 CellList                    ( ModelClassType ExtraStoryFirstCategoryCellList ExtraStoryFirstCategoryCellList ExtraStoryFirstCategoryCellList Pointer )
            value.UnreadStoryToggle                         = GetObject<UnreadStoryToggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnreadStoryToggle.FromPointer); // 0x28 UnreadStoryToggle           ( ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer )

            return value;
        }
    }
}
