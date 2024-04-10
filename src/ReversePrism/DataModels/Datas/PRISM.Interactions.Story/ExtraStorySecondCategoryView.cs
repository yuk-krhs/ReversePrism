using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiCharacterViewer                        0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 028 CharacterPositionAdjuster                000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer
    // 030 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 038 SecondCategoryCellList                   00018653D6C0 ModelClassType ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList Pointer
    public partial class ExtraStorySecondCategoryView : DataModel
    {
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ExtraStorySecondCategoryCellList?        SecondCategoryCellList                  { get; set; }

        public static ExtraStorySecondCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryView() { Pointer= p0 };

            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 02466B6B3578 0x20 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x028), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 02466B6B3598 0x28 CharacterPositionAdjuster   ( 000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B6B35B8 0x30 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.SecondCategoryCellList                    = GetObject<ExtraStorySecondCategoryCellList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExtraStorySecondCategoryCellList.FromPointer); // 02466B6B35D8 0x38 SecondCategoryCellList      ( 00018653D6C0 ModelClassType ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList Pointer )

            return value;
        }
    }
}
