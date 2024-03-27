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
    // 038 UnitSelectCellList                       00018672FD20 ModelClassType IntroductionUnitSelectCellList IntroductionUnitSelectCellList IntroductionUnitSelectCellList Pointer
    public partial class IntroductionUnitSelectView
    {
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IntroductionUnitSelectCellList?          UnitSelectCellList                      { get; set; }

        public static IntroductionUnitSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitSelectView();

            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0270DBC4D470 0x20 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x028), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0270DBC4D490 0x28 CharacterPositionAdjuster   ( 000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DBC4D4B0 0x30 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UnitSelectCellList                        = GetObject<IntroductionUnitSelectCellList>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntroductionUnitSelectCellList.FromPointer); // 0270DBC4D4D0 0x38 UnitSelectCellList          ( 00018672FD20 ModelClassType IntroductionUnitSelectCellList IntroductionUnitSelectCellList IntroductionUnitSelectCellList Pointer )

            return value;
        }
    }
}
