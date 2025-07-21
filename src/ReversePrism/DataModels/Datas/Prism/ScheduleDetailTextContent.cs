using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleDetailText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ScheduleDetailLevelObject                ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleDetailLevelText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ScheduleDetailSupportLevelObject         ModelClassType GameObject GameObject GameObject Pointer
    // 040 ScheduleDetailSupportLevelText           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ScheduleDetailSupportBonusObject         ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleDetailTextContent : DataModel
    {
        public UITextMeshProUGUI?                       ScheduleDetailText                      { get; set; }
        public GameObject?                              ScheduleDetailLevelObject               { get; set; }
        public UITextMeshProUGUI?                       ScheduleDetailLevelText                 { get; set; }
        public GameObject?                              ScheduleDetailSupportLevelObject        { get; set; }
        public UITextMeshProUGUI?                       ScheduleDetailSupportLevelText          { get; set; }
        public GameObject?                              ScheduleDetailSupportBonusObject        { get; set; }

        public static ScheduleDetailTextContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailTextContent() { Pointer= p0 };

            value.ScheduleDetailText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ScheduleDetailText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleDetailLevelObject                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ScheduleDetailLevelObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDetailLevelText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ScheduleDetailLevelText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleDetailSupportLevelObject          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ScheduleDetailSupportLevelObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDetailSupportLevelText            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ScheduleDetailSupportLevelText ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleDetailSupportBonusObject          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ScheduleDetailSupportBonusObject ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
