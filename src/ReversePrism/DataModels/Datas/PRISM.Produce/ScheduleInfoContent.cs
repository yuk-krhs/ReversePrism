using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleNameObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScheduleLevelObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleLevelText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ScheduleCategoryImage                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 ScheduleNameImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 SupportbonusObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 NoBonusObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ScheduleInfoContent : DataModel
    {
        public GameObject?                              ScheduleNameObject                      { get; set; }
        public GameObject?                              ScheduleLevelObject                     { get; set; }
        public UITextMeshProUGUI?                       ScheduleLevelText                       { get; set; }
        public UIImage?                                 ScheduleCategoryImage                   { get; set; }
        public UIImage?                                 ScheduleNameImage                       { get; set; }
        public GameObject?                              SupportbonusObject                      { get; set; }
        public GameObject?                              NoBonusObject                           { get; set; }

        public static ScheduleInfoContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleInfoContent() { Pointer= p0 };

            value.ScheduleNameObject                        = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90E90 0x20 ScheduleNameObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelObject                       = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90EB0 0x28 ScheduleLevelObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D90ED0 0x30 ScheduleLevelText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleCategoryImage                     = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 024665D90EF0 0x38 ScheduleCategoryImage       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleNameImage                         = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 024665D90F10 0x40 ScheduleNameImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SupportbonusObject                        = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90F30 0x48 SupportbonusObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoBonusObject                             = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90F50 0x50 NoBonusObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
