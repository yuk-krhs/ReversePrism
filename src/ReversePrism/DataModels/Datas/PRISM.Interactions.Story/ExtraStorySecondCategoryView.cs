using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiCharacterViewer                        ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 028 CharacterPositionAdjuster                ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer
    // 030 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 038 CellList                                 ModelClassType ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList Pointer
    // 040 UnreadStoryToggle                        ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer
    public partial class ExtraStorySecondCategoryView : DataModel
    {
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ExtraStorySecondCategoryCellList?        CellList                                { get; set; }
        public UnreadStoryToggle?                       UnreadStoryToggle                       { get; set; }

        public static ExtraStorySecondCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryView() { Pointer= p0 };

            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0x20 UiCharacterViewer           ( ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x028), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0x28 CharacterPositionAdjuster   ( ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x30 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<ExtraStorySecondCategoryCellList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExtraStorySecondCategoryCellList.FromPointer); // 0x38 CellList                    ( ModelClassType ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList ExtraStorySecondCategoryCellList Pointer )
            value.UnreadStoryToggle                         = GetObject<UnreadStoryToggle>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnreadStoryToggle.FromPointer); // 0x40 UnreadStoryToggle           ( ModelClassType UnreadStoryToggle UnreadStoryToggle UnreadStoryToggle Pointer )

            return value;
        }
    }
}
