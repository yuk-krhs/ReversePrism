using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               000186530800 ModelClassType SortFilteredStoryCell SortFilteredStoryCell SortFilteredStoryCell Pointer
    // 028 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 038 EmptyView                                0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer
    // 040 onClickCellSubject                       Subject`1<SortFilteredStoryCellData> IL2CPP_TYPE_GENERICINST
    // 048 onClickFavoriteToggleSubject             Subject`1<SortFilteredStoryCellData> IL2CPP_TYPE_GENERICINST
    // 050 InstantiatedCells                        000185D0AAF8 ModelClassListType List`1<SortFilteredStoryCell> List`1<SortFilteredStoryCell> List<SortFilteredStoryCell> Pointer
    // 058 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class StoryTopFavoriteContentCellList : DataModel
    {
        public SortFilteredStoryCell?                   CellPrefab                              { get; set; }
        public Transform?                               CellPos                                 { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public StoryEmptyView?                          EmptyView                               { get; set; }
        public List<SortFilteredStoryCell>?             InstantiatedCells                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static StoryTopFavoriteContentCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentCellList() { Pointer= p0 };

            value.CellPrefab                                = GetObject<SortFilteredStoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortFilteredStoryCell.FromPointer); // 02466BA06208 0x20 CellPrefab                  ( 000186530800 ModelClassType SortFilteredStoryCell SortFilteredStoryCell SortFilteredStoryCell Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466BA06228 0x28 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 02466BA06248 0x30 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.EmptyView                                 = GetObject<StoryEmptyView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryEmptyView.FromPointer); // 02466BA06268 0x38 EmptyView                   ( 0001865965E0 ModelClassType StoryEmptyView StoryEmptyView StoryEmptyView Pointer )
            value.InstantiatedCells                         = GetObjectList<SortFilteredStoryCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.SortFilteredStoryCell.FromPointer); // 02466BA062C8 0x50 InstantiatedCells           ( 000185D0AAF8 ModelClassListType List`1<SortFilteredStoryCell> List`1<SortFilteredStoryCell> List<SortFilteredStoryCell> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466BA062E8 0x58 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
