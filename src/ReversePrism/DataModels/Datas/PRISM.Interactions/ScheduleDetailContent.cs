using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ScheduleDetailTabGroupContent            0001866D37F0 ModelClassType ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent Pointer
    // 030 ParameterAreaPlusMemberContent           00018671A9D0 ModelClassType ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent Pointer
    // 038 ScheduleDetailImageContent               0001866D26B0 ModelClassType ScheduleDetailImageContent ScheduleDetailImageContent ScheduleDetailImageContent Pointer
    // 040 ScheduleDetailTextContent                0001866D3ED0 ModelClassType ScheduleDetailTextContent ScheduleDetailTextContent ScheduleDetailTextContent Pointer
    // 048 ChallengeMissionObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ScheduleChallengeMissionContent          0001866D10E0 ModelClassType ScheduleChallengeMissionContent ScheduleChallengeMissionContent ScheduleChallengeMissionContent Pointer
    // 058 ScheduleParameterContent                 0001866D6360 ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer
    // 060 ScheduleTroubleContent                   0001866E3B00 ModelClassType ScheduleTroubleContent ScheduleTroubleContent ScheduleTroubleContent Pointer
    // 068 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 070 ScheduleVitalityGauge                    0001866E5120 ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 078 CancelButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 ExecuteButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 BlackCoverObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 AlertTextObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 onClickCancel                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 onClickExecute                           Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 0B0 onClickTabChange                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0B8 CacheSchedule                            000186627C70 ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer
    // 0C0 CacheProduceBaseInfo                     0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 0C8 ScheduleDetail                           000186624F70 ModelClassType IScheduleDetailStatus IScheduleDetailStatus IScheduleDetailStatus Pointer
    // 0D0 Schedule                                 000186627C70 ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer
    // 0D8 cacheOnClickCancel                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 cacheOnClickExecute                      Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 0E8 IsInitilized                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleDetailContent : DataModel
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ScheduleDetailTabGroupContent?           ScheduleDetailTabGroupContent           { get; set; }
        public ParameterAreaPlusMemberContent?          ParameterAreaPlusMemberContent          { get; set; }
        public ScheduleDetailImageContent?              ScheduleDetailImageContent              { get; set; }
        public ScheduleDetailTextContent?               ScheduleDetailTextContent               { get; set; }
        public GameObject?                              ChallengeMissionObject                  { get; set; }
        public ScheduleChallengeMissionContent?         ScheduleChallengeMissionContent         { get; set; }
        public ScheduleParameterContent?                ScheduleParameterContent                { get; set; }
        public ScheduleTroubleContent?                  ScheduleTroubleContent                  { get; set; }
        public VitalityGauge?                           VitalityGauge                           { get; set; }
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
        public bool                                     IsInitilized                            { get; set; }

        public static ScheduleDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailContent() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1D6140 0x20 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleDetailTabGroupContent             = GetObject<ScheduleDetailTabGroupContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleDetailTabGroupContent.FromPointer); // 02466A1D6160 0x28 ScheduleDetailTabGroupContent ( 0001866D37F0 ModelClassType ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent ScheduleDetailTabGroupContent Pointer )
            value.ParameterAreaPlusMemberContent            = GetObject<ParameterAreaPlusMemberContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterAreaPlusMemberContent.FromPointer); // 02466A1D6180 0x30 ParameterAreaPlusMemberContent ( 00018671A9D0 ModelClassType ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent ParameterAreaPlusMemberContent Pointer )
            value.ScheduleDetailImageContent                = GetObject<ScheduleDetailImageContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleDetailImageContent.FromPointer); // 02466A1D61A0 0x38 ScheduleDetailImageContent  ( 0001866D26B0 ModelClassType ScheduleDetailImageContent ScheduleDetailImageContent ScheduleDetailImageContent Pointer )
            value.ScheduleDetailTextContent                 = GetObject<ScheduleDetailTextContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleDetailTextContent.FromPointer); // 02466A1D61C0 0x40 ScheduleDetailTextContent   ( 0001866D3ED0 ModelClassType ScheduleDetailTextContent ScheduleDetailTextContent ScheduleDetailTextContent Pointer )
            value.ChallengeMissionObject                    = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1D61E0 0x48 ChallengeMissionObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleChallengeMissionContent           = GetObject<ScheduleChallengeMissionContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScheduleChallengeMissionContent.FromPointer); // 02466A1D6200 0x50 ScheduleChallengeMissionContent ( 0001866D10E0 ModelClassType ScheduleChallengeMissionContent ScheduleChallengeMissionContent ScheduleChallengeMissionContent Pointer )
            value.ScheduleParameterContent                  = GetObject<ScheduleParameterContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleParameterContent.FromPointer); // 02466A1D6220 0x58 ScheduleParameterContent    ( 0001866D6360 ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer )
            value.ScheduleTroubleContent                    = GetObject<ScheduleTroubleContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleTroubleContent.FromPointer); // 02466A1D6240 0x60 ScheduleTroubleContent      ( 0001866E3B00 ModelClassType ScheduleTroubleContent ScheduleTroubleContent ScheduleTroubleContent Pointer )
            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x068), ReversePrism.DataModels.VitalityGauge.FromPointer); // 02466A1D6260 0x68 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.ScheduleVitalityGauge                     = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 02466A1D6280 0x70 ScheduleVitalityGauge       ( 0001866E5120 ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1D62A0 0x78 CancelButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExecuteButton                             = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1D62C0 0x80 ExecuteButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BlackCoverObject                          = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1D62E0 0x88 BlackCoverObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A1D6300 0x90 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AlertTextObject                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1D6320 0x98 AlertTextObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CacheSchedule                             = GetObject<IScheduleStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 02466A1D63A0 0xB8 CacheSchedule               ( 000186627C70 ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 02466A1D63C0 0xC0 CacheProduceBaseInfo        ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.ScheduleDetail                            = GetObject<IScheduleDetailStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 02466A1D63E0 0xC8 ScheduleDetail              ( 000186624F70 ModelClassType IScheduleDetailStatus IScheduleDetailStatus IScheduleDetailStatus Pointer )
            value.Schedule                                  = GetObject<IScheduleStatus>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 02466A1D6400 0xD0 Schedule                    ( 000186627C70 ModelClassType IScheduleStatus IScheduleStatus IScheduleStatus Pointer )
            value.IsInitilized                              = GetBool(new IntPtr(p + 0x0E8)); // 02466A1D6460 0xE8 IsInitilized                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
