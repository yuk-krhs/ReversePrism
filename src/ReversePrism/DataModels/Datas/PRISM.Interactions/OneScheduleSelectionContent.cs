using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FutureImageObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScheduleObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleImage                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 ScheduleLevelParentObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ScheduleLevelObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ScheduleLevelImage                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 ScheduleBonusLevelObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ScheduleLevelText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ScheduleNameText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 SupportBonusImageObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 RecommendImageObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 SupportCharacterAreaObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 SupportCharacterSDIconContentList        000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 088 ChallengeMissionObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 ChallengeMissionIconImage                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 098 SelectedScheduleImageObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 NonSelectedScheduleImageObject           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 CoverImageObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 TouchImageButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B8 FrameBlur                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0C0 BgGradation                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0C8 ScheduleLevelColorData                   00018657DC40 ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer
    // 0D0 onTouchImage                             Subject`1<ScheduleType> IL2CPP_TYPE_GENERICINST
    public partial class OneScheduleSelectionContent : DataModel
    {
        public GameObject?                              FutureImageObject                       { get; set; }
        public GameObject?                              ScheduleObject                          { get; set; }
        public UIRawImage?                              ScheduleImage                           { get; set; }
        public GameObject?                              ScheduleLevelParentObject               { get; set; }
        public GameObject?                              ScheduleLevelObject                     { get; set; }
        public UIImage?                                 ScheduleLevelImage                      { get; set; }
        public GameObject?                              ScheduleBonusLevelObject                { get; set; }
        public UITextMeshProUGUI?                       ScheduleLevelText                       { get; set; }
        public UITextMeshProUGUI?                       ScheduleNameText                        { get; set; }
        public GameObject?                              SupportBonusImageObject                 { get; set; }
        public GameObject?                              RecommendImageObject                    { get; set; }
        public GameObject?                              SupportCharacterAreaObject              { get; set; }
        public List<SupportCharacterSDIconContent>?     SupportCharacterSDIconContentList       { get; set; }
        public GameObject?                              ChallengeMissionObject                  { get; set; }
        public UIRawImage?                              ChallengeMissionIconImage               { get; set; }
        public GameObject?                              SelectedScheduleImageObject             { get; set; }
        public GameObject?                              NonSelectedScheduleImageObject          { get; set; }
        public GameObject?                              CoverImageObject                        { get; set; }
        public UIButton?                                TouchImageButton                        { get; set; }
        public UIImage?                                 FrameBlur                               { get; set; }
        public UIImage?                                 BgGradation                             { get; set; }
        public ProduceScheduleLevelColorData?           ScheduleLevelColorData                  { get; set; }

        public static OneScheduleSelectionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneScheduleSelectionContent() { Pointer= p0 };

            value.FutureImageObject                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BAFC8 0x20 FutureImageObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BAFE8 0x28 ScheduleObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1BB008 0x30 ScheduleImage               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ScheduleLevelParentObject                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB028 0x38 ScheduleLevelParentObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB048 0x40 ScheduleLevelObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelImage                        = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 02466A1BB068 0x48 ScheduleLevelImage          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleBonusLevelObject                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB088 0x50 ScheduleBonusLevelObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1BB0A8 0x58 ScheduleLevelText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1BB0C8 0x60 ScheduleNameText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusImageObject                   = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB0E8 0x68 SupportBonusImageObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RecommendImageObject                      = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB108 0x70 RecommendImageObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB128 0x78 SupportCharacterAreaObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 02466A1BB148 0x80 SupportCharacterSDIconContentList ( 000185D10348 ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.ChallengeMissionObject                    = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB168 0x88 ChallengeMissionObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeMissionIconImage                 = GetObject<UIRawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A1BB188 0x90 ChallengeMissionIconImage   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SelectedScheduleImageObject               = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB1A8 0x98 SelectedScheduleImageObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NonSelectedScheduleImageObject            = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB1C8 0xA0 NonSelectedScheduleImageObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CoverImageObject                          = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1BB1E8 0xA8 CoverImageObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchImageButton                          = GetObject<UIButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1BB208 0xB0 TouchImageButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FrameBlur                                 = GetObject<UIImage>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIImage.FromPointer); // 02466A1BB228 0xB8 FrameBlur                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BgGradation                               = GetObject<UIImage>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIImage.FromPointer); // 02466A1BB248 0xC0 BgGradation                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelColorData                    = GetObject<ProduceScheduleLevelColorData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ProduceScheduleLevelColorData.FromPointer); // 02466A1BB268 0xC8 ScheduleLevelColorData      ( 00018657DC40 ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer )

            return value;
        }
    }
}
