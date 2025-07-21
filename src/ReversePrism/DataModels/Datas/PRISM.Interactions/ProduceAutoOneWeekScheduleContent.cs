using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 028 ScheduleImage                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 ScheduleLevelObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 038 ScheduleBonusLevelObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ScheduleLevelImage                       ModelClassType UIImage UIImage UIImage Pointer
    // 048 ScheduleLevelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ScheduleNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SupportBonusImageObject                  ModelClassType GameObject GameObject GameObject Pointer
    // 060 AppearanceImageObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 068 RecommendImageObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 070 SupportCharacterAreaObject               ModelClassType GameObject GameObject GameObject Pointer
    // 078 SupportCharacterSDIconContentList        ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer
    // 080 FrameBlur                                ModelClassType UIImage UIImage UIImage Pointer
    // 088 BgGradation                              ModelClassType UIImage UIImage UIImage Pointer
    // 090 ScheduleLevelColorData                   ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer
    // 098 FailureUI                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProduceAutoOneWeekScheduleContent : DataModel
    {
        public GameObject?                              ScheduleObject                          { get; set; }
        public UIRawImage?                              ScheduleImage                           { get; set; }
        public GameObject?                              ScheduleLevelObject                     { get; set; }
        public GameObject?                              ScheduleBonusLevelObject                { get; set; }
        public UIImage?                                 ScheduleLevelImage                      { get; set; }
        public UITextMeshProUGUI?                       ScheduleLevelText                       { get; set; }
        public UITextMeshProUGUI?                       ScheduleNameText                        { get; set; }
        public GameObject?                              SupportBonusImageObject                 { get; set; }
        public GameObject?                              AppearanceImageObject                   { get; set; }
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
            var value   = new ProduceAutoOneWeekScheduleContent() { Pointer= p0 };

            value.ScheduleObject                            = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ScheduleObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 ScheduleImage               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ScheduleLevelObject                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ScheduleLevelObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleBonusLevelObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ScheduleBonusLevelObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelImage                        = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 ScheduleLevelImage          ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 ScheduleLevelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ScheduleNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusImageObject                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 SupportBonusImageObject     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AppearanceImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 AppearanceImageObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RecommendImageObject                      = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 RecommendImageObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterAreaObject                = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 SupportCharacterAreaObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportCharacterSDIconContentList         = GetObjectList<SupportCharacterSDIconContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportCharacterSDIconContent.FromPointer); // 0x78 SupportCharacterSDIconContentList ( ModelClassListType List`1<SupportCharacterSDIconContent> List`1<SupportCharacterSDIconContent> List<SupportCharacterSDIconContent> Pointer )
            value.FrameBlur                                 = GetObject<UIImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIImage.FromPointer); // 0x80 FrameBlur                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.BgGradation                               = GetObject<UIImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIImage.FromPointer); // 0x88 BgGradation                 ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScheduleLevelColorData                    = GetObject<ProduceScheduleLevelColorData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceScheduleLevelColorData.FromPointer); // 0x90 ScheduleLevelColorData      ( ModelClassType ProduceScheduleLevelColorData ProduceScheduleLevelColorData ProduceScheduleLevelColorData Pointer )
            value.FailureUI                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 FailureUI                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
