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
    // 000 TutorialWindowPath                       string IL2CPP_TYPE_STRING
    // 000 AuditionHowToPath                        string IL2CPP_TYPE_STRING
    // 000 EndButtonHowToPath                       string IL2CPP_TYPE_STRING
    // 010 MentalMaskSize                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 AppealMaskSize                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 ExclusionSize                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 CardMaskSize                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 CardMaskXAllSize                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 Card3MaskAllSize                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 SkilMaskSize                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 SkilMaskSizeAntica                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 CardHandMoveOffset                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 AvoidRateSize                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 StatusIconSize                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 StatusOneIconSize                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 070 StatusHandPosOffset                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 SkillDetaildSize                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 BuffDebuffDetaildSize                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 HandAngleZ                               ModelPrimitiveType float float float Single
    // 000 FirstWaitSec                             float IL2CPP_TYPE_R4
    // 000 ShowInfoLocalY                           float IL2CPP_TYPE_R4
    public partial class ProduceTutorialDefine : DataModel
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
            var value   = new ProduceTutorialDefine() { Pointer= p0 };

            value.MentalMaskSize                            = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 MentalMaskSize              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AppealMaskSize                            = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 AppealMaskSize              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ExclusionSize                             = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 ExclusionSize               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardMaskSize                              = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 CardMaskSize                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardMaskXAllSize                          = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 CardMaskXAllSize            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Card3MaskAllSize                          = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 Card3MaskAllSize            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkilMaskSize                              = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 SkilMaskSize                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkilMaskSizeAntica                        = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0x48 SkilMaskSizeAntica          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.CardHandMoveOffset                        = (Vector2)GetInt32(new IntPtr(p + 0x050)); // 0x50 CardHandMoveOffset          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AvoidRateSize                             = (Vector2)GetInt32(new IntPtr(p + 0x058)); // 0x58 AvoidRateSize               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusIconSize                            = (Vector2)GetInt32(new IntPtr(p + 0x060)); // 0x60 StatusIconSize              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusOneIconSize                         = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 0x68 StatusOneIconSize           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.StatusHandPosOffset                       = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0x70 StatusHandPosOffset         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkillDetaildSize                          = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 SkillDetaildSize            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BuffDebuffDetaildSize                     = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0x80 BuffDebuffDetaildSize       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.HandAngleZ                                = GetSingle(new IntPtr(p + 0x088)); // 0x88 HandAngleZ                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
