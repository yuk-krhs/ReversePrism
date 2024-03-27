using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               000186538180 ModelClassType ExtraStoryFirstCategoryCell ExtraStoryFirstCategoryCell ExtraStoryFirstCategoryCell Pointer
    // 028 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 038 EmptyView                                0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer
    // 040 onClickCellSubject                       Subject`1<ExtraStoryFirstCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 048 ReadCells                                000185CDC068 ModelClassListType List`1<ExtraStoryFirstCategoryCell> List`1<ExtraStoryFirstCategoryCell> List<ExtraStoryFirstCategoryCell> Pointer
    // 050 UnreadCellExists                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ExtraStoryFirstCategoryCellList
    {
        public ExtraStoryFirstCategoryCell?             CellPrefab                              { get; set; }
        public Transform?                               CellPos                                 { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public StoryEmptyView?                          EmptyView                               { get; set; }
        public List<ExtraStoryFirstCategoryCell>?       ReadCells                               { get; set; }
        public bool                                     UnreadCellExists                        { get; set; }

        public static ExtraStoryFirstCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryFirstCategoryCellList();

            value.CellPrefab                                = GetObject<ExtraStoryFirstCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStoryFirstCategoryCell.FromPointer); // 0270DB96F948 0x20 CellPrefab                  ( 000186538180 ModelClassType ExtraStoryFirstCategoryCell ExtraStoryFirstCategoryCell ExtraStoryFirstCategoryCell Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB96F968 0x28 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 0270DB96F988 0x30 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.EmptyView                                 = GetObject<StoryEmptyView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryEmptyView.FromPointer); // 0270DB96F9A8 0x38 EmptyView                   ( 0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer )
            value.ReadCells                                 = GetObjectList<ExtraStoryFirstCategoryCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExtraStoryFirstCategoryCell.FromPointer); // 0270DB96F9E8 0x48 ReadCells                   ( 000185CDC068 ModelClassListType List`1<ExtraStoryFirstCategoryCell> List`1<ExtraStoryFirstCategoryCell> List<ExtraStoryFirstCategoryCell> Pointer )
            value.UnreadCellExists                          = GetBool(new IntPtr(p + 0x050)); // 0270DB96FA08 0x50 UnreadCellExists            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
