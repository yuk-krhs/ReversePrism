using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               00018653CC80 ModelClassType ExtraStorySecondCategoryCell ExtraStorySecondCategoryCell ExtraStorySecondCategoryCell Pointer
    // 028 Scroller                                 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    // 030 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 onClickCellSubject                       Subject`1<ExtraStorySecondCategoryCellData> IL2CPP_TYPE_GENERICINST
    public partial class ExtraStorySecondCategoryCellList : DataModel
    {
        public ExtraStorySecondCategoryCell?            CellPrefab                              { get; set; }
        public StoryScroller?                           Scroller                                { get; set; }
        public Transform?                               CellPos                                 { get; set; }

        public static ExtraStorySecondCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryCellList() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ExtraStorySecondCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStorySecondCategoryCell.FromPointer); // 02466B9CF2A8 0x20 CellPrefab                  ( 00018653CC80 ModelClassType ExtraStorySecondCategoryCell ExtraStorySecondCategoryCell ExtraStorySecondCategoryCell Pointer )
            value.Scroller                                  = GetObject<StoryScroller>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryScroller.FromPointer); // 02466B9CF2C8 0x28 Scroller                    ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B9CF2E8 0x30 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
