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
    public partial class IdolBaseDetailUICharacterView
    {
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }

        public static IdolBaseDetailUICharacterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailUICharacterView();

            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0270DA26DAF0 0x20 UiCharacterViewer           ( 0001866E2C70 ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x028), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0270DA26DB10 0x28 CharacterPositionAdjuster   ( 000186553690 ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )

            return value;
        }
    }
}
