using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaColorBg                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 UiCharacterViewer                        0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer
    // 030 CharacterPositionAdjuster                000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer
    // 038 DearnessText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 048 CellList                                 0001866C77A0 ModelClassType IdolStoryLastCategoryCellList IdolStoryLastCategoryCellList IdolStoryLastCategoryCellList Pointer
    // 050 AdvTransitionerView                      0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer
    public partial class IdolStoryLastCategoryView
    {
        public UIImage?                                 CharaColorBg                            { get; set; }
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }
        public UITextMeshProUGUI?                       DearnessText                            { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IdolStoryLastCategoryCellList?           CellList                                { get; set; }
        public StoryToAdvTransitionerView?              AdvTransitionerView                     { get; set; }

        public static IdolStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryView();

            value.CharaColorBg                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB61FCD0 0x20 CharaColorBg                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x028), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0270DB61FCF0 0x28 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x030), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0270DB61FD10 0x30 CharacterPositionAdjuster   ( 000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )
            value.DearnessText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB61FD30 0x38 DearnessText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB61FD50 0x40 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<IdolStoryLastCategoryCellList>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolStoryLastCategoryCellList.FromPointer); // 0270DB61FD70 0x48 CellList                    ( 0001866C77A0 ModelClassType IdolStoryLastCategoryCellList IdolStoryLastCategoryCellList IdolStoryLastCategoryCellList Pointer )
            value.AdvTransitionerView                       = GetObject<StoryToAdvTransitionerView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StoryToAdvTransitionerView.FromPointer); // 0270DB61FD90 0x50 AdvTransitionerView         ( 0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer )

            return value;
        }
    }
}
