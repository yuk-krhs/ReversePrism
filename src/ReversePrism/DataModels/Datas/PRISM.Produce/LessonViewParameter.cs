using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleDetailType                       000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 014 ScheduleLevel                            0001865F4940 ModelPrimitiveType int int int Int32
    // 018 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 020 Episode                                  0001866336B0 ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer
    // 028 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 ProduceUnit                              0001865F7AD0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 038 DeckCards                                000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 040 TrainerData                              00018667B180 ModelClassType ITrainerStatus ITrainerStatus ITrainerStatus Pointer
    // 048 OpponentData                             0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 050 DifficultyType                           00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 058 ChallengeMission                         000186720230 ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer
    // 060 ChallengeMissionTargetPIdol              00018657D8B0 ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 068 ChallengeMissionUpParameter              000186713C30 ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer
    public partial class LessonViewParameter
    {
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      UnitID                                  { get; set; }
        public ISelectedEpisodeStatus?                  Episode                                 { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public IProduceUnitStatus?                      ProduceUnit                             { get; set; }
        public List<IProduceCardStatus>?                DeckCards                               { get; set; }
        public ITrainerStatus?                          TrainerData                             { get; set; }
        public IOpponentStatus?                         OpponentData                            { get; set; }
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public IChallengeMissionStatus?                 ChallengeMission                        { get; set; }
        public IInProduceIdolStatus?                    ChallengeMissionTargetPIdol             { get; set; }
        public IBuildUpParameterValueStatus?            ChallengeMissionUpParameter             { get; set; }

        public static LessonViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonViewParameter();

            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x010)); // 0270D5CB5B80 0x10 ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x014)); // 0270D5CB5BA0 0x14 ScheduleLevel               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5CB5BC0 0x18 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Episode                                   = GetObject<ISelectedEpisodeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISelectedEpisodeStatus.FromPointer); // 0270D5CB5BE0 0x20 Episode                     ( 0001866336B0 ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D5CB5C00 0x28 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnit                               = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0270D5CB5C20 0x30 ProduceUnit                 ( 0001865F7AD0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.DeckCards                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CB5C40 0x38 DeckCards                   ( 000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.TrainerData                               = GetObject<ITrainerStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITrainerStatus.FromPointer); // 0270D5CB5C60 0x40 TrainerData                 ( 00018667B180 ModelClassType ITrainerStatus ITrainerStatus ITrainerStatus Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0270D5CB5C80 0x48 OpponentData                ( 0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x050)); // 0270D5CB5CA0 0x50 DifficultyType              ( 00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.ChallengeMission                          = GetObject<IChallengeMissionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IChallengeMissionStatus.FromPointer); // 0270D5CB5CC0 0x58 ChallengeMission            ( 000186720230 ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer )
            value.ChallengeMissionTargetPIdol               = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0270D5CB5CE0 0x60 ChallengeMissionTargetPIdol ( 00018657D8B0 ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.ChallengeMissionUpParameter               = GetObject<IBuildUpParameterValueStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IBuildUpParameterValueStatus.FromPointer); // 0270D5CB5D00 0x68 ChallengeMissionUpParameter ( 000186713C30 ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
