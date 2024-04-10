using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EpisodeDifficultyStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyTypeFieldNumber                int IL2CPP_TYPE_I4
    // 018 DifficultyType                           00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 000 EpisodeStateTypeFieldNumber              int IL2CPP_TYPE_I4
    // 01C EpisodeStateType                         000186741BC0 ModelEnumType EpisodeStateType EpisodeStateType EpisodeStateType Int32
    // 000 SubSeasonConditionListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_subSeasonConditionList_codec   FieldCodec`1<SubSeasonConditionStatus> IL2CPP_TYPE_GENERICINST
    // 020 SubSeasonConditionList                   000185CF3938 ModelClassListType RepeatedField`1<SubSeasonConditionStatus> RepeatedField`1<SubSeasonConditionStatus> List<SubSeasonConditionStatus> Pointer
    // 000 InitialProduceCardDeckFieldNumber        int IL2CPP_TYPE_I4
    // 028 InitialProduceCardDeck                   000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    public partial class EpisodeDifficultyStatus : DataModel
    {
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public EpisodeStateType                         EpisodeStateType                        { get; set; }
        public List<SubSeasonConditionStatus>?          SubSeasonConditionList                  { get; set; }
        public ProduceCardDeckStatus?                   InitialProduceCardDeck                  { get; set; }

        public static EpisodeDifficultyStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeDifficultyStatus() { Pointer= p0 };

            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 02466103D7F8 0x18 DifficultyType              ( 00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.EpisodeStateType                          = (EpisodeStateType)GetInt32(new IntPtr(p + 0x01C)); // 02466103D838 0x1C EpisodeStateType            ( 000186741BC0 ModelEnumType EpisodeStateType EpisodeStateType EpisodeStateType Int32 )
            value.SubSeasonConditionList                    = GetObjectList<SubSeasonConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonConditionStatus.FromPointer); // 02466103D898 0x20 SubSeasonConditionList      ( 000185CF3938 ModelClassListType RepeatedField`1<SubSeasonConditionStatus> RepeatedField`1<SubSeasonConditionStatus> List<SubSeasonConditionStatus> Pointer )
            value.InitialProduceCardDeck                    = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 02466103D8D8 0x28 InitialProduceCardDeck      ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )

            return value;
        }
    }
}
