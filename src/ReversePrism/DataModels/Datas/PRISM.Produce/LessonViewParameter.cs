using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 014 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 018 UnitID                                   ModelPrimitiveType int int int Int32
    // 020 Episode                                  ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer
    // 028 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 ProduceUnit                              ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 038 DeckCards                                ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 040 TrainerData                              ModelClassType ITrainerStatus ITrainerStatus ITrainerStatus Pointer
    // 048 OpponentData                             ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 050 DifficultyType                           ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 058 ChallengeMission                         ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer
    // 060 ChallengeMissionTargetPIdol              ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 068 ChallengeMissionUpParameter              ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer
    public partial class LessonViewParameter : DataModel
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
            var value   = new LessonViewParameter() { Pointer= p0 };

            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.Episode                                   = GetObject<ISelectedEpisodeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISelectedEpisodeStatus.FromPointer); // 0x20 Episode                     ( ModelClassType ISelectedEpisodeStatus ISelectedEpisodeStatus ISelectedEpisodeStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x28 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnit                               = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0x30 ProduceUnit                 ( ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.DeckCards                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x38 DeckCards                   ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.TrainerData                               = GetObject<ITrainerStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITrainerStatus.FromPointer); // 0x40 TrainerData                 ( ModelClassType ITrainerStatus ITrainerStatus ITrainerStatus Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0x48 OpponentData                ( ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x050)); // 0x50 DifficultyType              ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.ChallengeMission                          = GetObject<IChallengeMissionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IChallengeMissionStatus.FromPointer); // 0x58 ChallengeMission            ( ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer )
            value.ChallengeMissionTargetPIdol               = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x60 ChallengeMissionTargetPIdol ( ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.ChallengeMissionUpParameter               = GetObject<IBuildUpParameterValueStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IBuildUpParameterValueStatus.FromPointer); // 0x68 ChallengeMissionUpParameter ( ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
