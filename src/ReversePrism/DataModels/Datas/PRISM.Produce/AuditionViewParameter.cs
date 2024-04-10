using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 EpisodeID                                0001865F4940 ModelPrimitiveType int int int Int32
    // 018 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 ProduceUnit                              0001865F7AD0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer
    // 028 ProduceIdols                             000185CFE9E8 ModelClassListType IReadOnlyList`1<IInProduceIdolStatus> IReadOnlyList`1<IInProduceIdolStatus> List<IInProduceIdolStatus> Pointer
    // 030 DeckCards                                000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 038 SupportSkills                            000185CFED18 ModelClassListType IReadOnlyList`1<IInProducePotentialSupportSkillStatus> IReadOnlyList`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 040 RivalUnitData                            000186621460 ModelClassType IRivalUnitStatus IRivalUnitStatus IRivalUnitStatus Pointer
    // 048 OpponentData                             0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 050 DifficultyType                           00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 054 Season                                   0001865F4940 ModelPrimitiveType int int int Int32
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

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 024665D163C0 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 024665D163E0 0x14 EpisodeID                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 024665D16400 0x18 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnit                               = GetObject<IProduceUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceUnitStatus.FromPointer); // 024665D16420 0x20 ProduceUnit                 ( 0001865F7AD0 ModelClassType IProduceUnitStatus IProduceUnitStatus IProduceUnitStatus Pointer )
            value.ProduceIdols                              = GetObjectList<IInProduceIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 024665D16440 0x28 ProduceIdols                ( 000185CFE9E8 ModelClassListType IReadOnlyList`1<IInProduceIdolStatus> IReadOnlyList`1<IInProduceIdolStatus> List<IInProduceIdolStatus> Pointer )
            value.DeckCards                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024665D16460 0x30 DeckCards                   ( 000185D06128 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.SupportSkills                             = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 024665D16480 0x38 SupportSkills               ( 000185CFED18 ModelClassListType IReadOnlyList`1<IInProducePotentialSupportSkillStatus> IReadOnlyList`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.RivalUnitData                             = GetObject<IRivalUnitStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IRivalUnitStatus.FromPointer); // 024665D164A0 0x40 RivalUnitData               ( 000186621460 ModelClassType IRivalUnitStatus IRivalUnitStatus IRivalUnitStatus Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 024665D164C0 0x48 OpponentData                ( 0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x050)); // 024665D164E0 0x50 DifficultyType              ( 00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x054)); // 024665D16500 0x54 Season                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
