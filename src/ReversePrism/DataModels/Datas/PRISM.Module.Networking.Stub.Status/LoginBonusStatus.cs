using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LoginBonusStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstLoginBonusIdFieldNumber               int IL2CPP_TYPE_I4
    // 028 MstLoginBonusId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LoginBonusTypeFieldNumber                int IL2CPP_TYPE_I4
    // 02C LoginBonusType                           0001865BB0B0 ModelEnumType LoginBonusType LoginBonusType LoginBonusType Int32
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 030 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 DisplayPriorityFieldNumber               int IL2CPP_TYPE_I4
    // 038 DisplayPriority                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CurrentSheetFieldNumber                  int IL2CPP_TYPE_I4
    // 040 CurrentSheet                             0001865B9810 ModelClassType LoginBonusSheetStatus LoginBonusSheetStatus LoginBonusSheetStatus Pointer
    // 000 NextSheetFieldNumber                     int IL2CPP_TYPE_I4
    // 048 NextSheet                                0001865B9810 ModelClassType LoginBonusSheetStatus LoginBonusSheetStatus LoginBonusSheetStatus Pointer
    // 000 AnnounceNextStepFieldNumber              int IL2CPP_TYPE_I4
    // 050 AnnounceNextStep                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 GraffitiResourceIdFieldNumber            int IL2CPP_TYPE_I4
    // 058 GraffitiResourceId                       000186671910 ModelPrimitiveType string string string String
    // 000 VoiceFieldNumber                         int IL2CPP_TYPE_I4
    // 060 Voice                                    000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer
    // 000 CostumeFieldNumber                       int IL2CPP_TYPE_I4
    // 068 Costume                                  00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer
    public partial class LoginBonusStatus
    {
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstLoginBonusId                         { get; set; }
        public LoginBonusType                           LoginBonusType                          { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      DisplayPriority                         { get; set; }
        public LoginBonusSheetStatus?                   CurrentSheet                            { get; set; }
        public LoginBonusSheetStatus?                   NextSheet                               { get; set; }
        public bool                                     AnnounceNextStep                        { get; set; }
        public string                                   GraffitiResourceId                      { get; set; }
        public VoiceResourceStatus?                     Voice                                   { get; set; }
        public CharacterCostumeStatus?                  Costume                                 { get; set; }

        public static LoginBonusStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusStatus();

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0270D22098E8 0x10 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstLoginBonusId                           = GetInt32(new IntPtr(p + 0x028)); // 0270D2209968 0x28 MstLoginBonusId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LoginBonusType                            = (LoginBonusType)GetInt32(new IntPtr(p + 0x02C)); // 0270D22099A8 0x2C LoginBonusType              ( 0001865BB0B0 ModelEnumType LoginBonusType LoginBonusType LoginBonusType Int32 )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D22099E8 0x30 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x038)); // 0270D2209A28 0x38 DisplayPriority             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSheet                              = GetObject<LoginBonusSheetStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LoginBonusSheetStatus.FromPointer); // 0270D2209A68 0x40 CurrentSheet                ( 0001865B9810 ModelClassType LoginBonusSheetStatus LoginBonusSheetStatus LoginBonusSheetStatus Pointer )
            value.NextSheet                                 = GetObject<LoginBonusSheetStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LoginBonusSheetStatus.FromPointer); // 0270D2209AA8 0x48 NextSheet                   ( 0001865B9810 ModelClassType LoginBonusSheetStatus LoginBonusSheetStatus LoginBonusSheetStatus Pointer )
            value.AnnounceNextStep                          = GetBool(new IntPtr(p + 0x050)); // 0270D2209AE8 0x50 AnnounceNextStep            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GraffitiResourceId                        = GetString(new IntPtr(p + 0x058)); // 0270D2209B28 0x58 GraffitiResourceId          ( 000186671910 ModelPrimitiveType string string string String )
            value.Voice                                     = GetObject<VoiceResourceStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoiceResourceStatus.FromPointer); // 0270D2209B68 0x60 Voice                       ( 000186539B30 ModelClassType VoiceResourceStatus VoiceResourceStatus VoiceResourceStatus Pointer )
            value.Costume                                   = GetObject<CharacterCostumeStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.CharacterCostumeStatus.FromPointer); // 0270D2209BA8 0x68 Costume                     ( 00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
