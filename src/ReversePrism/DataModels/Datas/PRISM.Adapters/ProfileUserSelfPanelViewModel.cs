using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasReplyData                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 ProduceIdolId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 CharacterMaster                          00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 020 ProducerName                             000186671910 ModelPrimitiveType string string string String
    // 028 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 030 AchievementIds                           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 Birthday                                 000186671910 ModelPrimitiveType string string string String
    // 040 IsBirthdayPublic                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 050 PlayerId                                 000186671910 ModelPrimitiveType string string string String
    // 058 SupportCharacterId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 SupportCharacterIcon                     0001866A9C80 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    public partial class ProfileUserSelfPanelViewModel : DataModel
    {
        public bool                                     HasReplyData                            { get; set; }
        public int                                      ProduceIdolId                           { get; set; }
        public MstCharacterInfo?                        CharacterMaster                         { get; set; }
        public string                                   ProducerName                            { get; set; }
        public string                                   DisplayName                             { get; set; }
        public List<int>?                               AchievementIds                          { get; set; }
        public string                                   Birthday                                { get; set; }
        public bool                                     IsBirthdayPublic                        { get; set; }
        public string                                   Comment                                 { get; set; }
        public string                                   PlayerId                                { get; set; }
        public int                                      SupportCharacterId                      { get; set; }
        public SCharaIcon?                              SupportCharacterIcon                    { get; set; }

        public static ProfileUserSelfPanelViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSelfPanelViewModel() { Pointer= p0 };

            value.HasReplyData                              = GetBool(new IntPtr(p + 0x010)); // 0246666E7070 0x10 HasReplyData                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolId                             = GetInt32(new IntPtr(p + 0x014)); // 0246666E7090 0x14 ProduceIdolId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CharacterMaster                           = GetObject<MstCharacterInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0246666E70B0 0x18 CharacterMaster             ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.ProducerName                              = GetString(new IntPtr(p + 0x020)); // 0246666E70D0 0x20 ProducerName                ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x028)); // 0246666E70F0 0x28 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.AchievementIds                            = GetInt32List(new IntPtr(p + 0x030)); // 0246666E7110 0x30 AchievementIds              ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Birthday                                  = GetString(new IntPtr(p + 0x038)); // 0246666E7130 0x38 Birthday                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsBirthdayPublic                          = GetBool(new IntPtr(p + 0x040)); // 0246666E7150 0x40 IsBirthdayPublic            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Comment                                   = GetString(new IntPtr(p + 0x048)); // 0246666E7170 0x48 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PlayerId                                  = GetString(new IntPtr(p + 0x050)); // 0246666E7190 0x50 PlayerId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SupportCharacterId                        = GetInt32(new IntPtr(p + 0x058)); // 0246666E71B0 0x58 SupportCharacterId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportCharacterIcon                      = GetObject<SCharaIcon>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0246666E71D0 0x60 SupportCharacterIcon        ( 0001866A9C80 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )

            return value;
        }
    }
}
