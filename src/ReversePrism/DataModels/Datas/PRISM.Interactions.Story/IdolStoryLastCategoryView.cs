using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             ModelClassType UIImage UIImage UIImage Pointer
    // 028 UiCharacterViewer                        ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 030 CharacterPositionAdjuster                ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer
    // 038 DearnessText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 048 CellList                                 ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer
    public partial class IdolStoryLastCategoryView : DataModel
    {
        public UIImage?                                 CharaColorBg                            { get; set; }
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }
        public UITextMeshProUGUI?                       DearnessText                            { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public StoryLastCategoryCellListView?           CellList                                { get; set; }

        public static IdolStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryView() { Pointer= p0 };

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 CharaColorBg                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x028), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0x28 UiCharacterViewer           ( ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x030), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0x30 CharacterPositionAdjuster   ( ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )
            value.DearnessText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 DearnessText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x40 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<StoryLastCategoryCellListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryLastCategoryCellListView.FromPointer); // 0x48 CellList                    ( ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer )

            return value;
        }
    }
}
