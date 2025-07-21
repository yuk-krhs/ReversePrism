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
    // 040 GetAppealPointCount                      ModelPrimitiveType int int int Int32
    // 044 PhaseChangeNum                           ModelPrimitiveType int int int Int32
    // 048 RankUpNum                                ModelPrimitiveType int int int Int32
    // 04C IsUseRankUpCard                          ModelPrimitiveType bool bool bool Bool
    // 04D IsIgnoreSafeSubMental                    ModelPrimitiveType bool bool bool Bool
    // 04E IsIgnoreMentalGurad                      ModelPrimitiveType bool bool bool Bool
    // 04F IsResetAvoidEffect                       ModelPrimitiveType bool bool bool Bool
    // 050 IsIgnoreSwapDamage                       ModelPrimitiveType bool bool bool Bool
    public partial class InGamePlayerActionResult : DataModel
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
        public int                                      GetAppealPointCount                     { get; set; }
        public int                                      PhaseChangeNum                          { get; set; }
        public int                                      RankUpNum                               { get; set; }
        public bool                                     IsUseRankUpCard                         { get; set; }
        public bool                                     IsIgnoreSafeSubMental                   { get; set; }
        public bool                                     IsIgnoreMentalGurad                     { get; set; }
        public bool                                     IsResetAvoidEffect                      { get; set; }
        public bool                                     IsIgnoreSwapDamage                      { get; set; }

        public static InGamePlayerActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePlayerActionResult() { Pointer= p0 };

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
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 GetAppealPointCount         ( ModelPrimitiveType int int int Int32 )
            value.PhaseChangeNum                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 PhaseChangeNum              ( ModelPrimitiveType int int int Int32 )
            value.RankUpNum                                 = GetInt32(new IntPtr(p + 0x048)); // 0x48 RankUpNum                   ( ModelPrimitiveType int int int Int32 )
            value.IsUseRankUpCard                           = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsUseRankUpCard             ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreSafeSubMental                     = GetBool(new IntPtr(p + 0x04D)); // 0x4D IsIgnoreSafeSubMental       ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreMentalGurad                       = GetBool(new IntPtr(p + 0x04E)); // 0x4E IsIgnoreMentalGurad         ( ModelPrimitiveType bool bool bool Bool )
            value.IsResetAvoidEffect                        = GetBool(new IntPtr(p + 0x04F)); // 0x4F IsResetAvoidEffect          ( ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreSwapDamage                        = GetBool(new IntPtr(p + 0x050)); // 0x50 IsIgnoreSwapDamage          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
