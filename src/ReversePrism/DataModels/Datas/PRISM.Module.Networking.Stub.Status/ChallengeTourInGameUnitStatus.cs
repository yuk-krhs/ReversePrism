using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 IdolListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_idolList_codec                 FieldCodec`1<ChallengeTourInGameIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolList                                 ModelClassListType RepeatedField`1<ChallengeTourInGameIdolStatus> RepeatedField`1<ChallengeTourInGameIdolStatus> List<ChallengeTourInGameIdolStatus> Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 028 ProduceCardDeck                          ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 030 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 000 SupportSkillListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_supportSkillList_codec         FieldCodec`1<ChallengeTourInGameSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 SupportSkillList                         ModelClassListType RepeatedField`1<ChallengeTourInGameSupportSkillStatus> RepeatedField`1<ChallengeTourInGameSupportSkillStatus> List<ChallengeTourInGameSupportSkillStatus> Pointer
    public partial class ChallengeTourInGameUnitStatus : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public List<ChallengeTourInGameIdolStatus>?     IdolList                                { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public List<ChallengeTourInGameSupportSkillStatus>? SupportSkillList                        { get; set; }

        public static ChallengeTourInGameUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameUnitStatus() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<ChallengeTourInGameIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourInGameIdolStatus.FromPointer); // 0x20 IdolList                    ( ModelClassListType RepeatedField`1<ChallengeTourInGameIdolStatus> RepeatedField`1<ChallengeTourInGameIdolStatus> List<ChallengeTourInGameIdolStatus> Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0x28 ProduceCardDeck             ( ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.SupportSkillList                          = GetObjectList<ChallengeTourInGameSupportSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourInGameSupportSkillStatus.FromPointer); // 0x38 SupportSkillList            ( ModelClassListType RepeatedField`1<ChallengeTourInGameSupportSkillStatus> RepeatedField`1<ChallengeTourInGameSupportSkillStatus> List<ChallengeTourInGameSupportSkillStatus> Pointer )

            return value;
        }
    }
}
