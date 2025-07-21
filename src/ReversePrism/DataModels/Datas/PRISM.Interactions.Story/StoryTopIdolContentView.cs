using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellGroupList                            ModelClassType IdolStoryFirstCategoryCellGroupList IdolStoryFirstCategoryCellGroupList IdolStoryFirstCategoryCellGroupList Pointer
    // 028 UnreadStoryToggle                        ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer
    public partial class StoryTopIdolContentView : DataModel
    {
        public IdolStoryFirstCategoryCellGroupList?     CellGroupList                           { get; set; }
        public UnreadStoryToggle?                       UnreadStoryToggle                       { get; set; }

        public static StoryTopIdolContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopIdolContentView() { Pointer= p0 };

            value.CellGroupList                             = GetObject<IdolStoryFirstCategoryCellGroupList>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStoryFirstCategoryCellGroupList.FromPointer); // 0x20 CellGroupList               ( ModelClassType IdolStoryFirstCategoryCellGroupList IdolStoryFirstCategoryCellGroupList IdolStoryFirstCategoryCellGroupList Pointer )
            value.UnreadStoryToggle                         = GetObject<UnreadStoryToggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnreadStoryToggle.FromPointer); // 0x28 UnreadStoryToggle           ( ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer )

            return value;
        }
    }
}
