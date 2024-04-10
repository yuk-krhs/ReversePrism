using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventNameText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 EventLabelImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 ScheduleText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AuditionText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SeasonThemeColorData                     00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer
    public partial class ScheduleSelectScheduleLabel : DataModel
    {
        public UITextMeshProUGUI?                       EventNameText                           { get; set; }
        public UIImage?                                 EventLabelImage                         { get; set; }
        public UITextMeshProUGUI?                       ScheduleText                            { get; set; }
        public UITextMeshProUGUI?                       AuditionText                            { get; set; }
        public ProduceSeasonThemeColorData?             SeasonThemeColorData                    { get; set; }

        public static ScheduleSelectScheduleLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectScheduleLabel() { Pointer= p0 };

            value.EventNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A202FF8 0x20 EventNameText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventLabelImage                           = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466A203018 0x28 EventLabelImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A203038 0x30 ScheduleText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AuditionText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A203058 0x38 AuditionText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeasonThemeColorData                      = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 02466A203078 0x40 SeasonThemeColorData        ( 00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )

            return value;
        }
    }
}
