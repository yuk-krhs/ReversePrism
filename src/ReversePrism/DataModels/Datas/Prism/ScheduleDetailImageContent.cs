using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ScheduleTextImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 RecommendObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SupportCharacterAreaObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 SupportCharacterSDIconContentList        000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 048 SupportCooperationCharacterObject        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 SupportCooperationCharacterImage         0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class ScheduleDetailImageContent : DataModel
    {
        public UIImage?                                 ScheduleImage                           { get; set; }
        public UIImage?                                 ScheduleTextImage                       { get; set; }
        public GameObject?                              RecommendObject                         { get; set; }
        public GameObject?                              SupportCharacterAreaObject              { get; set; }
        public List<SupportCharacterSDIconContent>?     SupportCharacterSDIconContentList       { get; set; }
        public GameObject?                              SupportCooperationCharacterObject       { get; set; }
        public UIImage?                                 SupportCooperationCharacterImage        { get; set; }

        public static ScheduleDetailImageContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailImageContent() { Pointer= p0 };

            value.ScheduleImage                             = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466A10CB40 0x20 ScheduleImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleTextImage                         = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466A10CB60 0x28 ScheduleTextImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.RecommendObject                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A10CB80 0x30 RecommendObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A10CBA0 0x38 SupportCharacterAreaObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 02466A10CBC0 0x40 SupportCharacterSDIconContentList ( 000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.SupportCooperationCharacterObject         = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466A10CBE0 0x48 SupportCooperationCharacterObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCooperationCharacterImage          = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466A10CC00 0x50 SupportCooperationCharacterImage ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
