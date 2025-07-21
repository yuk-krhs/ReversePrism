using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer
    // 028 Scroller                                 ModelClassType StoryLastCategoryScroller StoryLastCategoryScroller StoryLastCategoryScroller Pointer
    // 030 onClickCellSubject                       Subject`1<IStoryLastCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 038 onClickFavoriteToggleSubject             Subject`1<IStoryLastCategoryCellData> IL2CPP_TYPE_GENERICINST
    public partial class IdolStoryLastCategoryCellList : DataModel
    {
        public StoryLastCategoryCell?                   CellPrefab                              { get; set; }
        public StoryLastCategoryScroller?               Scroller                                { get; set; }

        public static IdolStoryLastCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryCellList() { Pointer= p0 };

            value.CellPrefab                                = GetObject<StoryLastCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryLastCategoryCell.FromPointer); // 0x20 CellPrefab                  ( ModelClassType StoryLastCategoryCell StoryLastCategoryCell StoryLastCategoryCell Pointer )
            value.Scroller                                  = GetObject<StoryLastCategoryScroller>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryLastCategoryScroller.FromPointer); // 0x28 Scroller                    ( ModelClassType StoryLastCategoryScroller StoryLastCategoryScroller StoryLastCategoryScroller Pointer )

            return value;
        }
    }
}
