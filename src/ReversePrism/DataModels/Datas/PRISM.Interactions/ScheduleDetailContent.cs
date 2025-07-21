using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AppearanceImageObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleDetailTabGroupContent            ModelClassType ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent Pointer
    // 038 ParameterAreaPlusMemberContent           ModelClassType ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent Pointer
    // 040 ScheduleDetailImageContent               ModelClassType ScheduleDetailImageContent ScheduleDetailImageContent ScheduleDetailImageContent Pointer
    // 048 ScheduleDetailTextContent                ModelClassType ScheduleDetailTextContent ScheduleDetailTextContent ScheduleDetailTextContent Pointer
    // 050 ChallengeMissionObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 058 ScheduleChallengeMissionContent          ModelClassType ScheduleChallengeMissionContent ScheduleChallengeMissionContent ScheduleChallengeMissionContent Pointer
    // 060 ScheduleParameterContent                 ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer
    // 068 ScheduleTroubleContent                   ModelClassType ScheduleTroubleContent ScheduleTroubleContent ScheduleTroubleContent Pointer
    // 070 ScheduleVitalityGauge                    ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 078 CancelButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 080 ExecuteButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 088 BlackCoverObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 090 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 AlertTextObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 CacheSchedule                            ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer
    // 0A8 CacheProduceBaseInfo                     ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 0B0 ScheduleDetail                           ModelClassType IScheduleDetailStatus IScheduleDetailStatus IScheduleDetailStatus Pointer
    // 0B8 Schedule                                 ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer
    // 0C0 cacheOnClickCancel                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C8 cacheOnClickExecute                      Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 0D0 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleDetailContent : DataModel
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public GameObject?                              AppearanceImageObject                   { get; set; }
        public ScheduleDetailTabGroupContent?           ScheduleDetailTabGroupContent           { get; set; }
        public ParameterAreaPlusMemberContent?          ParameterAreaPlusMemberContent          { get; set; }
        public ScheduleDetailImageContent?              ScheduleDetailImageContent              { get; set; }
        public ScheduleDetailTextContent?               ScheduleDetailTextContent               { get; set; }
        public GameObject?                              ChallengeMissionObject                  { get; set; }
        public ScheduleChallengeMissionContent?         ScheduleChallengeMissionContent         { get; set; }
        public ScheduleParameterContent?                ScheduleParameterContent                { get; set; }
        public ScheduleTroubleContent?                  ScheduleTroubleContent                  { get; set; }
        public ScheduleVitalityGauge?                   ScheduleVitalityGauge                   { get; set; }
        public UIButton?                                CancelButton                            { get; set; }
        public UIButton?                                ExecuteButton                           { get; set; }
        public GameObject?                              BlackCoverObject                        { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              AlertTextObject                         { get; set; }
        public IScheduleStatus?                         CacheSchedule                           { get; set; }
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }
        public IScheduleDetailStatus?                   ScheduleDetail                          { get; set; }
        public IScheduleStatus?                         Schedule                                { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static ScheduleDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailContent() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppearanceImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 AppearanceImageObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDetailTabGroupContent             = GetObject<ScheduleDetailTabGroupContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleDetailTabGroupContent.FromPointer); // 0x30 ScheduleDetailTabGroupContent ( ModelClassType ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent Pointer )
            value.ParameterAreaPlusMemberContent            = GetObject<ParameterAreaPlusMemberContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParameterAreaPlusMemberContent.FromPointer); // 0x38 ParameterAreaPlusMemberContent ( ModelClassType ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent Pointer )
            value.ScheduleDetailImageContent                = GetObject<ScheduleDetailImageContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleDetailImageContent.FromPointer); // 0x40 ScheduleDetailImageContent  ( ModelClassType ScheduleDetailImageContent ScheduleDetailImageContent ScheduleDetailImageContent Pointer )
            value.ScheduleDetailTextContent                 = GetObject<ScheduleDetailTextContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleDetailTextContent.FromPointer); // 0x48 ScheduleDetailTextContent   ( ModelClassType ScheduleDetailTextContent ScheduleDetailTextContent ScheduleDetailTextContent Pointer )
            value.ChallengeMissionObject                    = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 ChallengeMissionObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleChallengeMissionContent           = GetObject<ScheduleChallengeMissionContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleChallengeMissionContent.FromPointer); // 0x58 ScheduleChallengeMissionContent ( ModelClassType ScheduleChallengeMissionContent ScheduleChallengeMissionContent ScheduleChallengeMissionContent Pointer )
            value.ScheduleParameterContent                  = GetObject<ScheduleParameterContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleParameterContent.FromPointer); // 0x60 ScheduleParameterContent    ( ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer )
            value.ScheduleTroubleContent                    = GetObject<ScheduleTroubleContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScheduleTroubleContent.FromPointer); // 0x68 ScheduleTroubleContent      ( ModelClassType ScheduleTroubleContent ScheduleTroubleContent ScheduleTroubleContent Pointer )
            value.ScheduleVitalityGauge                     = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0x70 ScheduleVitalityGauge       ( ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 CancelButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ExecuteButton                             = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 ExecuteButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BlackCoverObject                          = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 BlackCoverObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x90 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AlertTextObject                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 AlertTextObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CacheSchedule                             = GetObject<IScheduleStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0xA0 CacheSchedule               ( ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0xA8 CacheProduceBaseInfo        ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ScheduleDetail                            = GetObject<IScheduleDetailStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0xB0 ScheduleDetail              ( ModelClassType IScheduleDetailStatus IScheduleDetailStatus IScheduleDetailStatus Pointer )
            value.Schedule                                  = GetObject<IScheduleStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0xB8 Schedule                    ( ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
