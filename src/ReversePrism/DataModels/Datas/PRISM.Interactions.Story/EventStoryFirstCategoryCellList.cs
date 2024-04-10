using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               000186767C90 ModelClassType EventStoryFirstCategoryCell EventStoryFirstCategoryCell EventStoryFirstCategoryCell Pointer
    // 028 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 038 EmptyView                                0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer
    // 040 onClickCellSubject                       Subject`1<EventStoryFirstCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 048 ReadCells                                000185CD9B38 ModelClassListType List`1<EventStoryFirstCategoryCell> List`1<EventStoryFirstCategoryCell> List<EventStoryFirstCategoryCell> Pointer
    // 050 UnreadCellExists                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventStoryFirstCategoryCellList : DataModel
    {
        public EventStoryFirstCategoryCell?             CellPrefab                              { get; set; }
        public Transform?                               CellPos                                 { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public StoryEmptyView?                          EmptyView                               { get; set; }
        public List<EventStoryFirstCategoryCell>?       ReadCells                               { get; set; }
        public bool                                     UnreadCellExists                        { get; set; }

        public static EventStoryFirstCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryFirstCategoryCellList() { Pointer= p0 };

            value.CellPrefab                                = GetObject<EventStoryFirstCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventStoryFirstCategoryCell.FromPointer); // 02466B9EF710 0x20 CellPrefab                  ( 000186767C90 ModelClassType EventStoryFirstCategoryCell EventStoryFirstCategoryCell EventStoryFirstCategoryCell Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B9EF730 0x28 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 02466B9EF750 0x30 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.EmptyView                                 = GetObject<StoryEmptyView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryEmptyView.FromPointer); // 02466B9EF770 0x38 EmptyView                   ( 0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer )
            value.ReadCells                                 = GetObjectList<EventStoryFirstCategoryCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventStoryFirstCategoryCell.FromPointer); // 02466B9EF7B0 0x48 ReadCells                   ( 000185CD9B38 ModelClassListType List`1<EventStoryFirstCategoryCell> List`1<EventStoryFirstCategoryCell> List<EventStoryFirstCategoryCell> Pointer )
            value.UnreadCellExists                          = GetBool(new IntPtr(p + 0x050)); // 02466B9EF7D0 0x50 UnreadCellExists            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
