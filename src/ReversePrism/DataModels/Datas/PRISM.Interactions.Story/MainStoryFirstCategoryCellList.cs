using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               0001865C8510 ModelClassType MainStoryFirstCategoryCell MainStoryFirstCategoryCell MainStoryFirstCategoryCell Pointer
    // 028 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 038 EmptyView                                0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer
    // 040 onClickCellSubject                       Subject`1<MainStoryFirstCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 048 ReadCells                                000185CF1278 ModelClassListType List`1<MainStoryFirstCategoryCell> List`1<MainStoryFirstCategoryCell> List<MainStoryFirstCategoryCell> Pointer
    // 050 UnreadCellExists                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MainStoryFirstCategoryCellList
    {
        public MainStoryFirstCategoryCell?              CellPrefab                              { get; set; }
        public Transform?                               CellPos                                 { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public StoryEmptyView?                          EmptyView                               { get; set; }
        public List<MainStoryFirstCategoryCell>?        ReadCells                               { get; set; }
        public bool                                     UnreadCellExists                        { get; set; }

        public static MainStoryFirstCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryFirstCategoryCellList();

            value.CellPrefab                                = GetObject<MainStoryFirstCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.MainStoryFirstCategoryCell.FromPointer); // 0270DB99EB50 0x20 CellPrefab                  ( 0001865C8510 ModelClassType MainStoryFirstCategoryCell MainStoryFirstCategoryCell MainStoryFirstCategoryCell Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB99EB70 0x28 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 0270DB99EB90 0x30 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.EmptyView                                 = GetObject<StoryEmptyView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryEmptyView.FromPointer); // 0270DB99EBB0 0x38 EmptyView                   ( 0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer )
            value.ReadCells                                 = GetObjectList<MainStoryFirstCategoryCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.MainStoryFirstCategoryCell.FromPointer); // 0270DB99EBF0 0x48 ReadCells                   ( 000185CF1278 ModelClassListType List`1<MainStoryFirstCategoryCell> List`1<MainStoryFirstCategoryCell> List<MainStoryFirstCategoryCell> Pointer )
            value.UnreadCellExists                          = GetBool(new IntPtr(p + 0x050)); // 0270DB99EC10 0x50 UnreadCellExists            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
