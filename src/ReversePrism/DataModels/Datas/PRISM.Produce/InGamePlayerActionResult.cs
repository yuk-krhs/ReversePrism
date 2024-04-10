using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecrementAppealPoint                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 AppealPointOnce                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 VoiceAppealPointOnce                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C DanceAppealPointOnce                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 VisualAppealPointOnce                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 RecoveryMental                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 DamageMental                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C SelfDamageMental                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 GetAppealPointCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 PhaseChangeNum                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 RankUpNum                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C IsUseRankUpCard                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D IsIgnoreSafeSubMental                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03E IsIgnoreMentalGurad                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03F IsResetAvoidEffect                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InGamePlayerActionResult : DataModel
    {
        public int                                      DecrementAppealPoint                    { get; set; }
        public int                                      AppealPointOnce                         { get; set; }
        public int                                      VoiceAppealPointOnce                    { get; set; }
        public int                                      DanceAppealPointOnce                    { get; set; }
        public int                                      VisualAppealPointOnce                   { get; set; }
        public int                                      RecoveryMental                          { get; set; }
        public int                                      DamageMental                            { get; set; }
        public int                                      SelfDamageMental                        { get; set; }
        public int                                      GetAppealPointCount                     { get; set; }
        public int                                      PhaseChangeNum                          { get; set; }
        public int                                      RankUpNum                               { get; set; }
        public bool                                     IsUseRankUpCard                         { get; set; }
        public bool                                     IsIgnoreSafeSubMental                   { get; set; }
        public bool                                     IsIgnoreMentalGurad                     { get; set; }
        public bool                                     IsResetAvoidEffect                      { get; set; }

        public static InGamePlayerActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGamePlayerActionResult() { Pointer= p0 };

            value.DecrementAppealPoint                      = GetInt32(new IntPtr(p + 0x010)); // 024665AFE1B8 0x10 DecrementAppealPoint        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AppealPointOnce                           = GetInt32(new IntPtr(p + 0x014)); // 024665AFE1D8 0x14 AppealPointOnce             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoiceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x018)); // 024665AFE1F8 0x18 VoiceAppealPointOnce        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x01C)); // 024665AFE218 0x1C DanceAppealPointOnce        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualAppealPointOnce                     = GetInt32(new IntPtr(p + 0x020)); // 024665AFE238 0x20 VisualAppealPointOnce       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RecoveryMental                            = GetInt32(new IntPtr(p + 0x024)); // 024665AFE258 0x24 RecoveryMental              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DamageMental                              = GetInt32(new IntPtr(p + 0x028)); // 024665AFE278 0x28 DamageMental                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelfDamageMental                          = GetInt32(new IntPtr(p + 0x02C)); // 024665AFE298 0x2C SelfDamageMental            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x030)); // 024665AFE2B8 0x30 GetAppealPointCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhaseChangeNum                            = GetInt32(new IntPtr(p + 0x034)); // 024665AFE2D8 0x34 PhaseChangeNum              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RankUpNum                                 = GetInt32(new IntPtr(p + 0x038)); // 024665AFE2F8 0x38 RankUpNum                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUseRankUpCard                           = GetBool(new IntPtr(p + 0x03C)); // 024665AFE318 0x3C IsUseRankUpCard             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreSafeSubMental                     = GetBool(new IntPtr(p + 0x03D)); // 024665AFE338 0x3D IsIgnoreSafeSubMental       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreMentalGurad                       = GetBool(new IntPtr(p + 0x03E)); // 024665AFE358 0x3E IsIgnoreMentalGurad         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsResetAvoidEffect                        = GetBool(new IntPtr(p + 0x03F)); // 024665AFE378 0x3F IsResetAvoidEffect          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
