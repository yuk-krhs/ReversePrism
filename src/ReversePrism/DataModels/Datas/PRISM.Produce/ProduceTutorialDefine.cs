using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TutorialConfigPath                       string IL2CPP_TYPE_STRING
    // 000 UnitName                                 string[] IL2CPP_TYPE_SZARRAY
    // 008 howToPlayPathList                        string[] IL2CPP_TYPE_SZARRAY
    // 000 TagName                                  string IL2CPP_TYPE_STRING
    // 000 HowToTagName                             string IL2CPP_TYPE_STRING
    // 000 TutorialWindowPath                       string IL2CPP_TYPE_STRING
    // 000 AuditionHowToPath                        string IL2CPP_TYPE_STRING
    // 000 EndButtonHowToPath                       string IL2CPP_TYPE_STRING
    // 010 MentalMaskSize                           0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 AppealMaskSize                           0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 ExclusionSize                            0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 CardMaskSize                             0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 CardMaskXAllSize                         0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 Card3MaskAllSize                         0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 SkilMaskSize                             0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 SkilMaskSizeAntica                       0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 CardHandMoveOffset                       0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 AvoidRateSize                            0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 StatusIconSize                           0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 StatusOneIconSize                        0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 070 StatusHandPosOffset                      0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 SkillDetaildSize                         0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 BuffDebuffDetaildSize                    0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 HandAngleZ                               000186667680 ModelPrimitiveType float float float Single
    // 000 FirstWaitSec                             float IL2CPP_TYPE_R4
    // 000 ShowInfoLocalY                           float IL2CPP_TYPE_R4
    public partial class ProduceTutorialDefine
    {
        public Vector2                                  MentalMaskSize                          { get; set; }
        public Vector2                                  AppealMaskSize                          { get; set; }
        public Vector2                                  ExclusionSize                           { get; set; }
        public Vector2                                  CardMaskSize                            { get; set; }
        public Vector2                                  CardMaskXAllSize                        { get; set; }
        public Vector2                                  Card3MaskAllSize                        { get; set; }
        public Vector2                                  SkilMaskSize                            { get; set; }
        public Vector2                                  SkilMaskSizeAntica                      { get; set; }
        public Vector2                                  CardHandMoveOffset                      { get; set; }
        public Vector2                                  AvoidRateSize                           { get; set; }
        public Vector2                                  StatusIconSize                          { get; set; }
        public Vector2                                  StatusOneIconSize                       { get; set; }
        public Vector2                                  StatusHandPosOffset                     { get; set; }
        public Vector2                                  SkillDetaildSize                        { get; set; }
        public Vector2                                  BuffDebuffDetaildSize                   { get; set; }
        public float                                    HandAngleZ                              { get; set; }

        public static ProduceTutorialDefine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialDefine();

            value.MentalMaskSize                            = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270D594F158 0x10 MentalMaskSize              ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AppealMaskSize                            = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0270D594F178 0x18 AppealMaskSize              ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ExclusionSize                             = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0270D594F198 0x20 ExclusionSize               ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardMaskSize                              = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0270D594F1B8 0x28 CardMaskSize                ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardMaskXAllSize                          = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0270D594F1D8 0x30 CardMaskXAllSize            ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Card3MaskAllSize                          = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0270D594F1F8 0x38 Card3MaskAllSize            ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkilMaskSize                              = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0270D594F218 0x40 SkilMaskSize                ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkilMaskSizeAntica                        = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0270D594F238 0x48 SkilMaskSizeAntica          ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardHandMoveOffset                        = (Vector2)GetInt32(new IntPtr(p + 0x050)); // 0270D594F258 0x50 CardHandMoveOffset          ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AvoidRateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x058)); // 0270D594F278 0x58 AvoidRateSize               ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusIconSize                            = (Vector2)GetInt32(new IntPtr(p + 0x060)); // 0270D594F298 0x60 StatusIconSize              ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusOneIconSize                         = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 0270D594F2B8 0x68 StatusOneIconSize           ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusHandPosOffset                       = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0270D594F2D8 0x70 StatusHandPosOffset         ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkillDetaildSize                          = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0270D594F2F8 0x78 SkillDetaildSize            ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BuffDebuffDetaildSize                     = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0270D594F318 0x80 BuffDebuffDetaildSize       ( 0001866A9AD0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.HandAngleZ                                = GetSingle(new IntPtr(p + 0x088)); // 0270D594F338 0x88 HandAngleZ                  ( 000186667680 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
