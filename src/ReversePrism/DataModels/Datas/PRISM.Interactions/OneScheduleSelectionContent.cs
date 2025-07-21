using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FutureImageObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScheduleObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleImage                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 ScheduleLevelParentObject                ModelClassType GameObject GameObject GameObject Pointer
    // 040 ScheduleLevelObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 ScheduleLevelImage                       ModelClassType UIImage UIImage UIImage Pointer
    // 050 ScheduleBonusLevelObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ScheduleLevelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ScheduleNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 SupportBonusImageObject                  ModelClassType GameObject GameObject GameObject Pointer
    // 070 AppearanceImageObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 078 RecommendImageObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 080 SupportCharacterAreaObject               ModelClassType GameObject GameObject GameObject Pointer
    // 088 SupportCharacterSDIconContentList        ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 090 ChallengeMissionObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 098 ChallengeMissionIconImage                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0A0 SelectedScheduleImageObject              ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 NonSelectedScheduleImageObject           ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 CoverImageObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 SuccessCoverObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 FailureCoverObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 TouchImageButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 FrameBlur                                ModelClassType UIImage UIImage UIImage Pointer
    // 0D8 BgGradation                              ModelClassType UIImage UIImage UIImage Pointer
    // 0E0 ScheduleLevelColorData                   ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer
    // 0E8 onTouchImage                             Subject`1<ScheduleType> IL2CPP_TYPE_GENERICINST
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
        public GameObject?                              AppearanceImageObject                   { get; set; }
        public GameObject?                              RecommendImageObject                    { get; set; }
        public GameObject?                              SupportCharacterAreaObject              { get; set; }
        public List<SupportCharacterSDIconContent>?     SupportCharacterSDIconContentList       { get; set; }
        public GameObject?                              ChallengeMissionObject                  { get; set; }
        public UIRawImage?                              ChallengeMissionIconImage               { get; set; }
        public GameObject?                              SelectedScheduleImageObject             { get; set; }
        public GameObject?                              NonSelectedScheduleImageObject          { get; set; }
        public GameObject?                              CoverImageObject                        { get; set; }
        public GameObject?                              SuccessCoverObject                      { get; set; }
        public GameObject?                              FailureCoverObject                      { get; set; }
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

            value.FutureImageObject                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 FutureImageObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ScheduleObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 ScheduleImage               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ScheduleLevelParentObject                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ScheduleLevelParentObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ScheduleLevelObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelImage                        = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 ScheduleLevelImage          ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleBonusLevelObject                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 ScheduleBonusLevelObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ScheduleLevelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 ScheduleNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusImageObject                   = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 SupportBonusImageObject     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AppearanceImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 AppearanceImageObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RecommendImageObject                      = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 RecommendImageObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 SupportCharacterAreaObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x088), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 0x88 SupportCharacterSDIconContentList ( ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.ChallengeMissionObject                    = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 ChallengeMissionObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeMissionIconImage                 = GetObject<UIRawImage>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x98 ChallengeMissionIconImage   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SelectedScheduleImageObject               = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 SelectedScheduleImageObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NonSelectedScheduleImageObject            = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 NonSelectedScheduleImageObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CoverImageObject                          = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 CoverImageObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SuccessCoverObject                        = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 SuccessCoverObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FailureCoverObject                        = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 FailureCoverObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchImageButton                          = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0xC8 TouchImageButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FrameBlur                                 = GetObject<UIImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIImage.FromPointer); // 0xD0 FrameBlur                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.BgGradation                               = GetObject<UIImage>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIImage.FromPointer); // 0xD8 BgGradation                 ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelColorData                    = GetObject<ProduceScheduleLevelColorData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ProduceScheduleLevelColorData.FromPointer); // 0xE0 ScheduleLevelColorData      ( ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer )

            return value;
        }
    }
}
