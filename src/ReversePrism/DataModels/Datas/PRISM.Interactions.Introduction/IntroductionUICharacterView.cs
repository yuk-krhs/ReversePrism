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
    public partial class IntroductionUICharacterView : DataModel
    {
        public UICharacterViewer?                       UiCharacterViewer                       { get; set; }
        public CenteringObjectsOutsideSafeArea?         CharacterPositionAdjuster               { get; set; }

        public static IntroductionUICharacterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUICharacterView() { Pointer= p0 };

            value.UiCharacterViewer                         = GetObject<UICharacterViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.UICharacterViewer.FromPointer); // 0x20 UiCharacterViewer           ( ModelClassType UICharacterViewer UICharacterViewer UICharacterViewer Pointer )
            value.CharacterPositionAdjuster                 = GetObject<CenteringObjectsOutsideSafeArea>(new IntPtr(p + 0x028), ReversePrism.DataModels.CenteringObjectsOutsideSafeArea.FromPointer); // 0x28 CharacterPositionAdjuster   ( ModelClassType CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea CenteringObjectsOutsideSafeArea Pointer )

            return value;
        }
    }
}
