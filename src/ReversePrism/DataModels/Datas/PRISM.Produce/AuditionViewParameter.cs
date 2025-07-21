using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 014 EpisodeID                                ModelPrimitiveType int int int Int32
    // 018 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 ProduceUnit                              ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 028 ProduceIdols                             ModelClassListType IReadOnlyList`1<IInProduceIdolStatus> IReadOnlyList`1<IInProduceIdolStatus> List<IInProduceIdolStatus> Pointer
    // 030 DeckCards                                ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 SupportSkills                            ModelClassListType IReadOnlyList`1<IInProducePotentialSupportSkillStatus> IReadOnlyList`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 040 RivalUnitData                            ModelClassType IRivalUnitStatus IRivalUnitStatus IRivalUnitStatus Pointer
    // 048 OpponentData                             ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 050 DifficultyType                           ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 054 Season                                   ModelPrimitiveType int int int Int32
    public partial class AuditionViewParameter : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      EpisodeID                               { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public IProduceUnitStatus?                      ProduceUnit                             { get; set; }
        public List<IInProduceIdolStatus>?              ProduceIdols                            { get; set; }
        public List<IProduceCardStatus>?                DeckCards                               { get; set; }
        public List<IInProducePotentialSupportSkillStatus>? SupportSkills                           { get; set; }
        public IRivalUnitStatus?                        RivalUnitData                           { get; set; }
        public IOpponentStatus?                         OpponentData                            { get; set; }
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public int                                      Season                                  { get; set; }

        public static AuditionViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionViewParameter() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeID                   ( ModelPrimitiveType int int int Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x18 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnit                               = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 0x20 ProduceUnit                 ( ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.ProduceIdols                              = GetObjectList<IInProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x28 ProduceIdols                ( ModelClassListType IReadOnlyList`1<IInProduceIdolStatus> IReadOnlyList`1<IInProduceIdolStatus> List<IInProduceIdolStatus> Pointer )
            value.DeckCards                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x30 DeckCards                   ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.SupportSkills                             = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0x38 SupportSkills               ( ModelClassListType IReadOnlyList`1<IInProducePotentialSupportSkillStatus> IReadOnlyList`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.RivalUnitData                             = GetObject<IRivalUnitStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IRivalUnitStatus.FromPointer); // 0x40 RivalUnitData               ( ModelClassType IRivalUnitStatus IRivalUnitStatus IRivalUnitStatus Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0x48 OpponentData                ( ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x050)); // 0x50 DifficultyType              ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x054)); // 0x54 Season                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
