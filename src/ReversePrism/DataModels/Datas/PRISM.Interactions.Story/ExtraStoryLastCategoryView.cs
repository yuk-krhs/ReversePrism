using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ViewTitle                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 CellList                                 00018653A540 ModelClassType ExtraStoryLastCategoryCellList ExtraStoryLastCategoryCellList ExtraStoryLastCategoryCellList Pointer
    // 038 AdvTransitionerView                      0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer
    public partial class ExtraStoryLastCategoryView
    {
        public UIImage?                                 BgImage                                 { get; set; }
        public CommonTitleView?                         ViewTitle                               { get; set; }
        public ExtraStoryLastCategoryCellList?          CellList                                { get; set; }
        public StoryToAdvTransitionerView?              AdvTransitionerView                     { get; set; }

        public static ExtraStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryView();

            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB646B88 0x20 BgImage                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ViewTitle                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB646BA8 0x28 ViewTitle                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<ExtraStoryLastCategoryCellList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExtraStoryLastCategoryCellList.FromPointer); // 0270DB646BC8 0x30 CellList                    ( 00018653A540 ModelClassType ExtraStoryLastCategoryCellList ExtraStoryLastCategoryCellList ExtraStoryLastCategoryCellList Pointer )
            value.AdvTransitionerView                       = GetObject<StoryToAdvTransitionerView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryToAdvTransitionerView.FromPointer); // 0270DB646BE8 0x38 AdvTransitionerView         ( 0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer )

            return value;
        }
    }
}
