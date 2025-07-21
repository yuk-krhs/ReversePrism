using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecrementAppealPoint                     ModelPrimitiveType int int int Int32
    // 014 AppealPointOnce                          ModelPrimitiveType int int int Int32
    // 018 VoiceAppealPointOnce                     ModelPrimitiveType int int int Int32
    // 01C DanceAppealPointOnce                     ModelPrimitiveType int int int Int32
    // 020 VisualAppealPointOnce                    ModelPrimitiveType int int int Int32
    // 024 RecoveryMental                           ModelPrimitiveType int int int Int32
    // 028 DamageMental                             ModelPrimitiveType int int int Int32
    // 02C MentalGuard                              ModelPrimitiveType int int int Int32
    // 030 AddAvoidRate                             ModelPrimitiveType int int int Int32
    // 034 SelfDamageMental                         ModelPrimitiveType int int int Int32
    // 038 FixMental                                ModelPrimitiveType int int int Int32
    // 03C IsSafeDamage                             ModelPrimitiveType bool bool bool Bool
    // 03D IsIgnoreSafeSubMental                    ModelPrimitiveType bool bool bool Bool
    // 03E IsIgnoreSwapDamage                       ModelPrimitiveType bool bool bool Bool
    // 03F IsIgnoreMentalGurad                      ModelPrimitiveType bool bool bool Bool
    // 040 IsResetAvoidEffect                       ModelPrimitiveType bool bool bool Bool
    // 044 GetAppealPointCount                      ModelPrimitiveType int int int Int32
    // 048 PlayerModel                              ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    public partial class CardAndSkillPlayerPredictionModel : DataModel
    {
        public int                                      DecrementAppealPoint                    { get; set; }
        public int                                      AppealPointOnce                         { get; set; }
        public int                                      VoiceAppealPointOnce                    { get; set; }
        public int                                      DanceAppealPointOnce                    { get; set; }
        public int                                      VisualAppealPointOnce                   { get; set; }
        public int                                      RecoveryMental                          { get; set; }
        public int                                      DamageMental                            { get; set; }
        public int                                      MentalGuard                             { get; set; }
        public int                                      AddAvoidRate                            { get; set; }
        public int                                      SelfDamageMental                        { get; set; }
        public int                                      FixMental                               { get; set; }
        public bool                                     IsSafeDamage                            { get; set; }
        public bool                                     IsIgnoreSafeSubMental                   { get; set; }
        public bool                                     IsIgnoreSwapDamage                      { get; set; }
        public bool                                     IsIgnoreMentalGurad                     { get; set; }
        public bool                                     IsResetAvoidEffect                      { get; set; }
        public int                                      GetAppealPointCount                     { get; set; }
        public IngamePlayerModel?                       PlayerModel                             { get; set; }

        public static CardAndSkillPlayerPredictionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardAndSkillPlayerPredictionModel() { Pointer= p0 };

            value.DecrementAppealPoint                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 DecrementAppealPoint        ( ModelPrimitiveType int int int Int32 )
            value.AppealPointOnce                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 AppealPointOnce             ( ModelPrimitiveType int int int Int32 )
            value.VoiceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 VoiceAppealPointOnce        ( ModelPrimitiveType int int int Int32 )
            value.DanceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DanceAppealPointOnce        ( ModelPrimitiveType int int int Int32 )
            value.VisualAppealPointOnce                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 VisualAppealPointOnce       ( ModelPrimitiveType int int int Int32 )
            value.RecoveryMental                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 RecoveryMental              ( ModelPrimitiveType int int int Int32 )
            value.DamageMental                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 DamageMental                ( ModelPrimitiveType int int int Int32 )
            value.MentalGuard                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MentalGuard                 ( ModelPrimitiveType int int int Int32 )
            value.AddAvoidRate                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 AddAvoidRate                ( ModelPrimitiveType int int int Int32 )
            value.SelfDamageMental                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 SelfDamageMental            ( ModelPrimitiveType int int int Int32 )
            value.FixMental                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 FixMental                   ( ModelPrimitiveType int int int Int32 )
            value.IsSafeDamage                              = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsSafeDamage                ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreSafeSubMental                     = GetBool(new IntPtr(p + 0x03D)); // 0x3D IsIgnoreSafeSubMental       ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreSwapDamage                        = GetBool(new IntPtr(p + 0x03E)); // 0x3E IsIgnoreSwapDamage          ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreMentalGurad                       = GetBool(new IntPtr(p + 0x03F)); // 0x3F IsIgnoreMentalGurad         ( ModelPrimitiveType bool bool bool Bool )
            value.IsResetAvoidEffect                        = GetBool(new IntPtr(p + 0x040)); // 0x40 IsResetAvoidEffect          ( ModelPrimitiveType bool bool bool Bool )
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x044)); // 0x44 GetAppealPointCount         ( ModelPrimitiveType int int int Int32 )
            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x48 PlayerModel                 ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )

            return value;
        }
    }
}
