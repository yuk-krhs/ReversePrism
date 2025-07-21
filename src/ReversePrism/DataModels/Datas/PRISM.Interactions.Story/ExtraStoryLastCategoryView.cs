using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  ModelClassType UIImage UIImage UIImage Pointer
    // 028 ViewTitle                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 CellList                                 ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer
    public partial class ExtraStoryLastCategoryView : DataModel
    {
        public UIImage?                                 BgImage                                 { get; set; }
        public CommonTitleView?                         ViewTitle                               { get; set; }
        public StoryLastCategoryCellListView?           CellList                                { get; set; }

        public static ExtraStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryView() { Pointer= p0 };

            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BgImage                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ViewTitle                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 ViewTitle                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<StoryLastCategoryCellListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryLastCategoryCellListView.FromPointer); // 0x30 CellList                    ( ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer )

            return value;
        }
    }
}
