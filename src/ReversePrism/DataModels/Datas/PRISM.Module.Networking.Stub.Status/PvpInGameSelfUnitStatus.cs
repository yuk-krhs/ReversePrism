using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpInGameSelfUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_idolList_codec                 FieldCodec`1<PvpInGameIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolList                                 000185CED738 ModelClassListType RepeatedField`1<PvpInGameIdolStatus> RepeatedField`1<PvpInGameIdolStatus> List<PvpInGameIdolStatus> Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 028 ProduceCardDeck                          000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_supportSkillList_codec         FieldCodec`1<PvpInGameSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportSkillList                         000185CED9A8 ModelClassListType RepeatedField`1<PvpInGameSupportSkillStatus> RepeatedField`1<PvpInGameSupportSkillStatus> List<PvpInGameSupportSkillStatus> Pointer
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 038 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PvpInGameSelfUnitStatus
    {
        public int                                      MstUnitId                               { get; set; }
        public List<PvpInGameIdolStatus>?               IdolList                                { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public List<PvpInGameSupportSkillStatus>?       SupportSkillList                        { get; set; }
        public int                                      MstEpisodeId                            { get; set; }

        public static PvpInGameSelfUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameSelfUnitStatus();

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D1437868 0x18 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<PvpInGameIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpInGameIdolStatus.FromPointer); // 0270D14378C8 0x20 IdolList                    ( 000185CED738 ModelClassListType RepeatedField`1<PvpInGameIdolStatus> RepeatedField`1<PvpInGameIdolStatus> List<PvpInGameIdolStatus> Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0270D1437908 0x28 ProduceCardDeck             ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.SupportSkillList                          = GetObjectList<PvpInGameSupportSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpInGameSupportSkillStatus.FromPointer); // 0270D1437968 0x30 SupportSkillList            ( 000185CED9A8 ModelClassListType RepeatedField`1<PvpInGameSupportSkillStatus> RepeatedField`1<PvpInGameSupportSkillStatus> List<PvpInGameSupportSkillStatus> Pointer )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x038)); // 0270D14379A8 0x38 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
