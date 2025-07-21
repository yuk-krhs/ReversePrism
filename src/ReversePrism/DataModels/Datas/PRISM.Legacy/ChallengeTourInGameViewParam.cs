using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     ModelClassType IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus Pointer
    // 018 RivalUnit                                ModelClassType IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus Pointer
    // 020 Stage                                    ModelClassType IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus Pointer
    // 028 Opponent                                 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer
    // 030 Rewards                                  ModelClassListType IReadOnlyList`1<IChallengeTourStageRewardStatus> IReadOnlyList`1<IChallengeTourStageRewardStatus> List<IChallengeTourStageRewardStatus> Pointer
    // 038 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 040 UnitIndex                                ModelPrimitiveType int int int Int32
    // 044 StageIndex                               ModelPrimitiveType int int int Int32
    // 048 UnitId                                   ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameViewParam : DataModel
    {
        public IChallengeTourInGameUnitStatus?          Unit                                    { get; set; }
        public IChallengeTourRivalUnitStatus?           RivalUnit                               { get; set; }
        public IChallengeTourInGameStageStatus?         Stage                                   { get; set; }
        public IChallengeTourOpponentStatus?            Opponent                                { get; set; }
        public List<IChallengeTourStageRewardStatus>?   Rewards                                 { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public int                                      StageIndex                              { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static ChallengeTourInGameViewParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameViewParam() { Pointer= p0 };

            value.Unit                                      = GetObject<IChallengeTourInGameUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourInGameUnitStatus.FromPointer); // 0x10 Unit                        ( ModelClassType IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus Pointer )
            value.RivalUnit                                 = GetObject<IChallengeTourRivalUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourRivalUnitStatus.FromPointer); // 0x18 RivalUnit                   ( ModelClassType IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus Pointer )
            value.Stage                                     = GetObject<IChallengeTourInGameStageStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IChallengeTourInGameStageStatus.FromPointer); // 0x20 Stage                       ( ModelClassType IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus Pointer )
            value.Opponent                                  = GetObject<IChallengeTourOpponentStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IChallengeTourOpponentStatus.FromPointer); // 0x28 Opponent                    ( ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer )
            value.Rewards                                   = GetObjectList<IChallengeTourStageRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IChallengeTourStageRewardStatus.FromPointer); // 0x30 Rewards                     ( ModelClassListType IReadOnlyList`1<IChallengeTourStageRewardStatus> IReadOnlyList`1<IChallengeTourStageRewardStatus> List<IChallengeTourStageRewardStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x038), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x38 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 UnitIndex                   ( ModelPrimitiveType int int int Int32 )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 StageIndex                  ( ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 UnitId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
