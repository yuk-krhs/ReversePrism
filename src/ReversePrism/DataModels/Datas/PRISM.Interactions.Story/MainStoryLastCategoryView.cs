using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 CellList                                 0001865CA6F0 ModelClassType MainStoryLastCategoryCellList MainStoryLastCategoryCellList MainStoryLastCategoryCellList Pointer
    // 030 AdvTransitionerView                      0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer
    public partial class MainStoryLastCategoryView : DataModel
    {
        public UIImage?                                 BgImage                                 { get; set; }
        public MainStoryLastCategoryCellList?           CellList                                { get; set; }
        public StoryToAdvTransitionerView?              AdvTransitionerView                     { get; set; }

        public static MainStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryView() { Pointer= p0 };

            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466B6D2DE8 0x20 BgImage                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CellList                                  = GetObject<MainStoryLastCategoryCellList>(new IntPtr(p + 0x028), ReversePrism.DataModels.MainStoryLastCategoryCellList.FromPointer); // 02466B6D2E08 0x28 CellList                    ( 0001865CA6F0 ModelClassType MainStoryLastCategoryCellList MainStoryLastCategoryCellList MainStoryLastCategoryCellList Pointer )
            value.AdvTransitionerView                       = GetObject<StoryToAdvTransitionerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryToAdvTransitionerView.FromPointer); // 02466B6D2E28 0x30 AdvTransitionerView         ( 0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer )

            return value;
        }
    }
}
