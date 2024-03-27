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
    // 030 IsIgnoreSafeSubMental                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsIgnoreMentalGurad                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsResetAvoidEffect                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 GetAppealPointCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 PlayerModel                              0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    public partial class CardAndSkillPlayerPredictionModel
    {
        public int                                      DecrementAppealPoint                    { get; set; }
        public int                                      AppealPointOnce                         { get; set; }
        public int                                      VoiceAppealPointOnce                    { get; set; }
        public int                                      DanceAppealPointOnce                    { get; set; }
        public int                                      VisualAppealPointOnce                   { get; set; }
        public int                                      RecoveryMental                          { get; set; }
        public int                                      DamageMental                            { get; set; }
        public int                                      SelfDamageMental                        { get; set; }
        public bool                                     IsIgnoreSafeSubMental                   { get; set; }
        public bool                                     IsIgnoreMentalGurad                     { get; set; }
        public bool                                     IsResetAvoidEffect                      { get; set; }
        public int                                      GetAppealPointCount                     { get; set; }
        public IngamePlayerModel?                       PlayerModel                             { get; set; }

        public static CardAndSkillPlayerPredictionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardAndSkillPlayerPredictionModel();

            value.DecrementAppealPoint                      = GetInt32(new IntPtr(p + 0x010)); // 0270D59D7F50 0x10 DecrementAppealPoint        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AppealPointOnce                           = GetInt32(new IntPtr(p + 0x014)); // 0270D59D7F70 0x14 AppealPointOnce             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoiceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x018)); // 0270D59D7F90 0x18 VoiceAppealPointOnce        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceAppealPointOnce                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D59D7FB0 0x1C DanceAppealPointOnce        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualAppealPointOnce                     = GetInt32(new IntPtr(p + 0x020)); // 0270D59D7FD0 0x20 VisualAppealPointOnce       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RecoveryMental                            = GetInt32(new IntPtr(p + 0x024)); // 0270D59D7FF0 0x24 RecoveryMental              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DamageMental                              = GetInt32(new IntPtr(p + 0x028)); // 0270D59D8010 0x28 DamageMental                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelfDamageMental                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D59D8030 0x2C SelfDamageMental            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsIgnoreSafeSubMental                     = GetBool(new IntPtr(p + 0x030)); // 0270D59D8050 0x30 IsIgnoreSafeSubMental       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsIgnoreMentalGurad                       = GetBool(new IntPtr(p + 0x031)); // 0270D59D8070 0x31 IsIgnoreMentalGurad         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsResetAvoidEffect                        = GetBool(new IntPtr(p + 0x032)); // 0270D59D8090 0x32 IsResetAvoidEffect          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GetAppealPointCount                       = GetInt32(new IntPtr(p + 0x034)); // 0270D59D80B0 0x34 GetAppealPointCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0270D59D80D0 0x38 PlayerModel                 ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )

            return value;
        }
    }
}
