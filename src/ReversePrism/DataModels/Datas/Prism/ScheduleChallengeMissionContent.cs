using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MissionDescriptionText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MissionIdolImage                         ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    public partial class ScheduleChallengeMissionContent : DataModel
    {
        public UITextMeshProUGUI?                       MissionDescriptionText                  { get; set; }
        public UIRawImage?                              MissionIdolImage                        { get; set; }

        public static ScheduleChallengeMissionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleChallengeMissionContent() { Pointer= p0 };

            value.MissionDescriptionText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MissionDescriptionText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionIdolImage                          = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 MissionIdolImage            ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
