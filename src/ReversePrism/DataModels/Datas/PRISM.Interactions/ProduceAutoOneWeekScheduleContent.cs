using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScheduleImage                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 ScheduleLevelObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ScheduleBonusLevelObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ScheduleLevelImage                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 ScheduleLevelText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ScheduleNameText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SupportBonusImageObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 RecommendImageObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 SupportCharacterAreaObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 SupportCharacterSDIconContentList        000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 078 FrameBlur                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 080 BgGradation                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 088 ScheduleLevelColorData                   00018657DC40 ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer
    // 090 FailureUI                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProduceAutoOneWeekScheduleContent
    {
        public GameObject?                              ScheduleObject                          { get; set; }
        public UIRawImage?                              ScheduleImage                           { get; set; }
        public GameObject?                              ScheduleLevelObject                     { get; set; }
        public GameObject?                              ScheduleBonusLevelObject                { get; set; }
        public UIImage?                                 ScheduleLevelImage                      { get; set; }
        public UITextMeshProUGUI?                       ScheduleLevelText                       { get; set; }
        public UITextMeshProUGUI?                       ScheduleNameText                        { get; set; }
        public GameObject?                              SupportBonusImageObject                 { get; set; }
        public GameObject?                              RecommendImageObject                    { get; set; }
        public GameObject?                              SupportCharacterAreaObject              { get; set; }
        public List<SupportCharacterSDIconContent>?     SupportCharacterSDIconContentList       { get; set; }
        public UIImage?                                 FrameBlur                               { get; set; }
        public UIImage?                                 BgGradation                             { get; set; }
        public ProduceScheduleLevelColorData?           ScheduleLevelColorData                  { get; set; }
        public GameObject?                              FailureUI                               { get; set; }

        public static ProduceAutoOneWeekScheduleContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneWeekScheduleContent();

            value.ScheduleObject                            = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE2D0 0x20 ScheduleObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA0CE2F0 0x28 ScheduleImage               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ScheduleLevelObject                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE310 0x30 ScheduleLevelObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleBonusLevelObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE330 0x38 ScheduleBonusLevelObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelImage                        = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0CE350 0x40 ScheduleLevelImage          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0CE370 0x48 ScheduleLevelText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0CE390 0x50 ScheduleNameText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusImageObject                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE3B0 0x58 SupportBonusImageObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RecommendImageObject                      = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE3D0 0x60 RecommendImageObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE3F0 0x68 SupportCharacterAreaObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 0270DA0CE410 0x70 SupportCharacterSDIconContentList ( 000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.FrameBlur                                 = GetObject<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0CE430 0x78 FrameBlur                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BgGradation                               = GetObject<UIImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0CE450 0x80 BgGradation                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelColorData                    = GetObject<ProduceScheduleLevelColorData>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceScheduleLevelColorData.FromPointer); // 0270DA0CE470 0x88 ScheduleLevelColorData      ( 00018657DC40 ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer )
            value.FailureUI                                 = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0CE490 0x90 FailureUI                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
