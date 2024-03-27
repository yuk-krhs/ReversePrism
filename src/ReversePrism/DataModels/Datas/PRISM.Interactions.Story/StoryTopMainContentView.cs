using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellList                                 0001865C8EB0 ModelClassType MainStoryFirstCategoryCellList MainStoryFirstCategoryCellList MainStoryFirstCategoryCellList Pointer
    // 028 UnreadStoryToggle                        000186735EA0 ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer
    public partial class StoryTopMainContentView
    {
        public MainStoryFirstCategoryCellList?          CellList                                { get; set; }
        public UnreadStoryToggle?                       UnreadStoryToggle                       { get; set; }

        public static StoryTopMainContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopMainContentView();

            value.CellList                                  = GetObject<MainStoryFirstCategoryCellList>(new IntPtr(p + 0x020), ReversePrism.DataModels.MainStoryFirstCategoryCellList.FromPointer); // 0270DB9A65A8 0x20 CellList                    ( 0001865C8EB0 ModelClassType MainStoryFirstCategoryCellList MainStoryFirstCategoryCellList MainStoryFirstCategoryCellList Pointer )
            value.UnreadStoryToggle                         = GetObject<UnreadStoryToggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnreadStoryToggle.FromPointer); // 0270DB9A65C8 0x28 UnreadStoryToggle           ( 000186735EA0 ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer )

            return value;
        }
    }
}
