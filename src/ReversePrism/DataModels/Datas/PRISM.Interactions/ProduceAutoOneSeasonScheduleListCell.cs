using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SeasonText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ScheduleContents                         000185B9C780 ModelClassListType ProduceAutoOneWeekScheduleContent[] ProduceAutoOneWeekScheduleContent[] List<ProduceAutoOneWeekScheduleContent> Pointer
    public partial class ProduceAutoOneSeasonScheduleListCell : DataModel
    {
        public UITextMeshProUGUI?                       SeasonText                              { get; set; }
        public List<ProduceAutoOneWeekScheduleContent>? ScheduleContents                        { get; set; }

        public static ProduceAutoOneSeasonScheduleListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneSeasonScheduleListCell() { Pointer= p0 };

            value.SeasonText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1225D8 0x60 SeasonText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleContents                          = GetObjectList<ProduceAutoOneWeekScheduleContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceAutoOneWeekScheduleContent.FromPointer); // 02466A1225F8 0x68 ScheduleContents            ( 000185B9C780 ModelClassListType ProduceAutoOneWeekScheduleContent[] ProduceAutoOneWeekScheduleContent[] List<ProduceAutoOneWeekScheduleContent> Pointer )

            return value;
        }
    }
}
