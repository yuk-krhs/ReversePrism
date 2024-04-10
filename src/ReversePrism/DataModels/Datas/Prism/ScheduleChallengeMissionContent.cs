using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MissionDescriptionText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 MissionIdolImage                         0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
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

            value.MissionDescriptionText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A10C840 0x20 MissionDescriptionText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionIdolImage                          = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A10C860 0x28 MissionIdolImage            ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
